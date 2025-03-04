// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The rule criteria that defines the conditions of the scheduled query rule. </summary>
    internal partial class ScheduledQueryRuleCriteria
    {
        /// <summary> Initializes a new instance of ScheduledQueryRuleCriteria. </summary>
        public ScheduledQueryRuleCriteria()
        {
            AllOf = new ChangeTrackingList<ScheduledQueryRuleCondition>();
        }

        /// <summary> Initializes a new instance of ScheduledQueryRuleCriteria. </summary>
        /// <param name="allOf"> A list of conditions to evaluate against the specified scopes. </param>
        internal ScheduledQueryRuleCriteria(IList<ScheduledQueryRuleCondition> allOf)
        {
            AllOf = allOf;
        }

        /// <summary> A list of conditions to evaluate against the specified scopes. </summary>
        public IList<ScheduledQueryRuleCondition> AllOf { get; }
    }
}
