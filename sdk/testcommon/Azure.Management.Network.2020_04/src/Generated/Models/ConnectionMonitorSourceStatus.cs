// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Status of connection monitor source. </summary>
    public readonly partial struct ConnectionMonitorSourceStatus : IEquatable<ConnectionMonitorSourceStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ConnectionMonitorSourceStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionMonitorSourceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ActiveValue = "Active";
        private const string InactiveValue = "Inactive";

        /// <summary> Unknown. </summary>
        public static ConnectionMonitorSourceStatus Unknown { get; } = new ConnectionMonitorSourceStatus(UnknownValue);
        /// <summary> Active. </summary>
        public static ConnectionMonitorSourceStatus Active { get; } = new ConnectionMonitorSourceStatus(ActiveValue);
        /// <summary> Inactive. </summary>
        public static ConnectionMonitorSourceStatus Inactive { get; } = new ConnectionMonitorSourceStatus(InactiveValue);
        /// <summary> Determines if two <see cref="ConnectionMonitorSourceStatus"/> values are the same. </summary>
        public static bool operator ==(ConnectionMonitorSourceStatus left, ConnectionMonitorSourceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectionMonitorSourceStatus"/> values are not the same. </summary>
        public static bool operator !=(ConnectionMonitorSourceStatus left, ConnectionMonitorSourceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectionMonitorSourceStatus"/>. </summary>
        public static implicit operator ConnectionMonitorSourceStatus(string value) => new ConnectionMonitorSourceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectionMonitorSourceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectionMonitorSourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}