/*
 * Zipkin API
 *
 * Zipkin's v2 api currently includes a POST endpoint that can receive spans. 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace LetsTrace.Zipkin.Transport.ZipkinJSON
{ 
    /// <summary>
    /// The network context of a node in the service graph
    /// </summary>
    [DataContract]
    public partial class Endpoint : IEquatable<Endpoint>
    { 
        /// <summary>
        /// Lower-case label of this node in the service graph, such as \&quot;favstar\&quot;. Leave absent if unknown.  This is a primary label for trace lookup and aggregation, so it should be intuitive and consistent. Many use a name from service discovery. 
        /// </summary>
        /// <value>Lower-case label of this node in the service graph, such as \&quot;favstar\&quot;. Leave absent if unknown.  This is a primary label for trace lookup and aggregation, so it should be intuitive and consistent. Many use a name from service discovery. </value>
        [DataMember(Name="serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// The text representation of the primary IPv4 address associated with this a connection. Ex. 192.168.99.100 Absent if unknown. 
        /// </summary>
        /// <value>The text representation of the primary IPv4 address associated with this a connection. Ex. 192.168.99.100 Absent if unknown. </value>
        [DataMember(Name="ipv4")]
        public string Ipv4 { get; set; }

        /// <summary>
        /// The text representation of the primary IPv6 address associated with this a connection. Ex. 2001:db8::c001 Absent if unknown.  Prefer using the ipv4 field for mapped addresses. 
        /// </summary>
        /// <value>The text representation of the primary IPv6 address associated with this a connection. Ex. 2001:db8::c001 Absent if unknown.  Prefer using the ipv4 field for mapped addresses. </value>
        [DataMember(Name="ipv6")]
        public string Ipv6 { get; set; }

        /// <summary>
        /// Depending on context, this could be a listen port or the client-side of a socket. Absent if unknown 
        /// </summary>
        /// <value>Depending on context, this could be a listen port or the client-side of a socket. Absent if unknown </value>
        [DataMember(Name="port")]
        public int? Port { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Endpoint {\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Ipv4: ").Append(Ipv4).Append("\n");
            sb.Append("  Ipv6: ").Append(Ipv6).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Endpoint)obj);
        }

        /// <summary>
        /// Returns true if Endpoint instances are equal
        /// </summary>
        /// <param name="other">Instance of Endpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Endpoint other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ServiceName == other.ServiceName ||
                    ServiceName != null &&
                    ServiceName.Equals(other.ServiceName)
                ) && 
                (
                    Ipv4 == other.Ipv4 ||
                    Ipv4 != null &&
                    Ipv4.Equals(other.Ipv4)
                ) && 
                (
                    Ipv6 == other.Ipv6 ||
                    Ipv6 != null &&
                    Ipv6.Equals(other.Ipv6)
                ) && 
                (
                    Port == other.Port ||
                    Port != null &&
                    Port.Equals(other.Port)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ServiceName != null)
                    hashCode = hashCode * 59 + ServiceName.GetHashCode();
                    if (Ipv4 != null)
                    hashCode = hashCode * 59 + Ipv4.GetHashCode();
                    if (Ipv6 != null)
                    hashCode = hashCode * 59 + Ipv6.GetHashCode();
                    if (Port != null)
                    hashCode = hashCode * 59 + Port.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Endpoint left, Endpoint right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Endpoint left, Endpoint right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
