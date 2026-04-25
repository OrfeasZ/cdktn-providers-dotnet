using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DnsRecord
{
    [JsiiByValue(fqn: "cloudflare.dnsRecord.DnsRecordData")]
    public class DnsRecordData : cloudflare.DnsRecord.IDnsRecordData
    {
        /// <summary>Algorithm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#algorithm DnsRecord#algorithm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Algorithm
        {
            get;
            set;
        }

        /// <summary>Altitude of location in meters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#altitude DnsRecord#altitude}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "altitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Altitude
        {
            get;
            set;
        }

        /// <summary>Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#certificate DnsRecord#certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Certificate
        {
            get;
            set;
        }

        /// <summary>Digest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#digest DnsRecord#digest}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Digest
        {
            get;
            set;
        }

        /// <summary>Digest Type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#digest_type DnsRecord#digest_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "digestType", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DigestType
        {
            get;
            set;
        }

        /// <summary>Fingerprint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#fingerprint DnsRecord#fingerprint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fingerprint
        {
            get;
            set;
        }

        /// <summary>Flags for the CAA record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#flags DnsRecord#flags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? Flags
        {
            get;
            set;
        }

        /// <summary>Key Tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#key_tag DnsRecord#key_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyTag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KeyTag
        {
            get;
            set;
        }

        /// <summary>Degrees of latitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#lat_degrees DnsRecord#lat_degrees}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "latDegrees", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LatDegrees
        {
            get;
            set;
        }

        /// <summary>Latitude direction. Available values: "N", "S".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#lat_direction DnsRecord#lat_direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "latDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LatDirection
        {
            get;
            set;
        }

        /// <summary>Minutes of latitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#lat_minutes DnsRecord#lat_minutes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "latMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LatMinutes
        {
            get;
            set;
        }

        /// <summary>Seconds of latitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#lat_seconds DnsRecord#lat_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "latSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LatSeconds
        {
            get;
            set;
        }

        /// <summary>Degrees of longitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#long_degrees DnsRecord#long_degrees}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "longDegrees", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LongDegrees
        {
            get;
            set;
        }

        /// <summary>Longitude direction. Available values: "E", "W".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#long_direction DnsRecord#long_direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "longDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LongDirection
        {
            get;
            set;
        }

        /// <summary>Minutes of longitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#long_minutes DnsRecord#long_minutes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "longMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LongMinutes
        {
            get;
            set;
        }

        /// <summary>Seconds of longitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#long_seconds DnsRecord#long_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "longSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LongSeconds
        {
            get;
            set;
        }

        /// <summary>Matching Type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#matching_type DnsRecord#matching_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchingType", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MatchingType
        {
            get;
            set;
        }

        /// <summary>Order.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#order DnsRecord#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Order
        {
            get;
            set;
        }

        /// <summary>The port of the service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#port DnsRecord#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Horizontal precision of location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#precision_horz DnsRecord#precision_horz}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "precisionHorz", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PrecisionHorz
        {
            get;
            set;
        }

        /// <summary>Vertical precision of location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#precision_vert DnsRecord#precision_vert}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "precisionVert", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PrecisionVert
        {
            get;
            set;
        }

        /// <summary>Preference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#preference DnsRecord#preference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Preference
        {
            get;
            set;
        }

        /// <summary>Priority.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#priority DnsRecord#priority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#protocol DnsRecord#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Protocol
        {
            get;
            set;
        }

        /// <summary>Public Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#public_key DnsRecord#public_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicKey
        {
            get;
            set;
        }

        /// <summary>Regex.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#regex DnsRecord#regex}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Regex
        {
            get;
            set;
        }

        /// <summary>Replacement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#replacement DnsRecord#replacement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replacement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Replacement
        {
            get;
            set;
        }

        /// <summary>Selector.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#selector DnsRecord#selector}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Selector
        {
            get;
            set;
        }

        /// <summary>Service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#service DnsRecord#service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Service
        {
            get;
            set;
        }

        /// <summary>Size of location in meters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#size DnsRecord#size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
        {
            get;
            set;
        }

        /// <summary>Name of the property controlled by this record (e.g.: issue, issuewild, iodef).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#tag DnsRecord#tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tag
        {
            get;
            set;
        }

        /// <summary>Target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#target DnsRecord#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }

        /// <summary>Type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#type DnsRecord#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Type
        {
            get;
            set;
        }

        /// <summary>Usage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#usage DnsRecord#usage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Usage
        {
            get;
            set;
        }

        /// <summary>Value of the record. This field's semantics depend on the chosen tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#value DnsRecord#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }

        /// <summary>The record weight.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/dns_record#weight DnsRecord#weight}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
