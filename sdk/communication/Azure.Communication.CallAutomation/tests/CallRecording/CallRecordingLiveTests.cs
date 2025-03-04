﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.Communication.CallAutomation
{
    internal class CallRecordingLiveTests : CallAutomationClientLiveTestsBase
    {
        public CallRecordingLiveTests(bool isAsync) : base(isAsync)
        { }

        [Test]
        public async Task RecordingOperations()
        {
            if (SkipCallAutomationInteractionLiveTests)
            {
                Assert.Ignore("Skip CallAutomation interaction live tests flag is on");
            }

            CallAutomationClient client = CreateInstrumentedCallAutomationClientWithConnectionString();
            string callConnectionId = "";
            bool stopRecording = false;
            try
            {
                var user = await CreateIdentityUserAsync().ConfigureAwait(false);
                var targetUser = TestEnvironment.TargetUserId;
                string ngrok = "https://localhost";
                var targets = new CommunicationIdentifier[] { new CommunicationUserIdentifier(targetUser) };
                var callResponse = await client.CreateCallAsync(new CallSource(user), targets, new Uri(ngrok)).ConfigureAwait(false);
                Assert.NotNull(callResponse);
                Assert.NotNull(callResponse.Value);
                await WaitForOperationCompletion().ConfigureAwait(false);

                var callProperties = await client.GetCallConnection(callResponse.Value.CallConnectionProperties.CallConnectionId).GetCallConnectionPropertiesAsync();
                Assert.NotNull(callProperties);
                Assert.NotNull(callProperties.Value);

                string serverCallId = callProperties.Value.ServerCallId;
                callConnectionId = callProperties.Value.CallConnectionId;
                CallRecording callRecording = client.GetCallRecording();
                StartRecordingOptions recordingOptions = new StartRecordingOptions(new ServerCallLocator(serverCallId))
                {
                    RecordingStateCallbackEndpoint = new Uri(ngrok)
                };
                var recordingResponse = await callRecording.StartRecordingAsync(recordingOptions).ConfigureAwait(false);
                Assert.NotNull(recordingResponse.Value);

                var recordingId = recordingResponse.Value.RecordingId;
                Assert.NotNull(recordingId);
                await WaitForOperationCompletion().ConfigureAwait(false);

                recordingResponse = await callRecording.GetRecordingStateAsync(recordingId).ConfigureAwait(false);
                Assert.NotNull(recordingResponse.Value);
                Assert.NotNull(recordingResponse.Value.RecordingState);
                Assert.AreEqual(recordingResponse.Value.RecordingState, RecordingState.Active);

                await callRecording.PauseRecordingAsync(recordingId);
                await WaitForOperationCompletion().ConfigureAwait(false);
                recordingResponse = await callRecording.GetRecordingStateAsync(recordingId).ConfigureAwait(false);
                Assert.NotNull(recordingResponse.Value);
                Assert.NotNull(recordingResponse.Value.RecordingState);
                Assert.AreEqual(recordingResponse.Value.RecordingState, RecordingState.Inactive);

                await callRecording.ResumeRecordingAsync(recordingId);
                await WaitForOperationCompletion().ConfigureAwait(false);
                recordingResponse = await callRecording.GetRecordingStateAsync(recordingId).ConfigureAwait(false);
                Assert.NotNull(recordingResponse.Value);
                Assert.NotNull(recordingResponse.Value.RecordingState);
                Assert.AreEqual(recordingResponse.Value.RecordingState, RecordingState.Active);

                await callRecording.StopRecordingAsync(recordingId);
                await WaitForOperationCompletion().ConfigureAwait(false);
                stopRecording = true;
                recordingResponse = await callRecording.GetRecordingStateAsync(recordingId).ConfigureAwait(false);
            }
            catch (RequestFailedException ex)
            {
                if (ex.Status == 404 && stopRecording)
                {
                    // recording stopped successfully
                    Assert.Pass();
                }
                Assert.Fail($"Unexpected error: {ex}");
            }
            finally
            {
                var callConnection = client.GetCallConnection(callConnectionId);
                await callConnection.HangUpAsync(true).ConfigureAwait(false);
            }
        }
    }
}
