// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Value indicating whether this adapter is RDMA capable. </summary>
    public readonly partial struct NetworkAdapterRdmaStatus : IEquatable<NetworkAdapterRdmaStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkAdapterRdmaStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkAdapterRdmaStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IncapableValue = "Incapable";
        private const string CapableValue = "Capable";

        /// <summary> Incapable. </summary>
        public static NetworkAdapterRdmaStatus Incapable { get; } = new NetworkAdapterRdmaStatus(IncapableValue);
        /// <summary> Capable. </summary>
        public static NetworkAdapterRdmaStatus Capable { get; } = new NetworkAdapterRdmaStatus(CapableValue);
        /// <summary> Determines if two <see cref="NetworkAdapterRdmaStatus"/> values are the same. </summary>
        public static bool operator ==(NetworkAdapterRdmaStatus left, NetworkAdapterRdmaStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkAdapterRdmaStatus"/> values are not the same. </summary>
        public static bool operator !=(NetworkAdapterRdmaStatus left, NetworkAdapterRdmaStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkAdapterRdmaStatus"/>. </summary>
        public static implicit operator NetworkAdapterRdmaStatus(string value) => new NetworkAdapterRdmaStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkAdapterRdmaStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkAdapterRdmaStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
