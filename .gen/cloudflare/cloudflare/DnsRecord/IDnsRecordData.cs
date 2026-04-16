using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DnsRecord
{
    [JsiiInterface(nativeType: typeof(IDnsRecordData), fullyQualifiedName: "cloudflare.dnsRecord.DnsRecordData")]
    public interface IDnsRecordData
    {
        /// <summary>Algorithm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#algorithm DnsRecord#algorithm}
        /// </remarks>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Algorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Altitude of location in meters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#altitude DnsRecord#altitude}
        /// </remarks>
        [JsiiProperty(name: "altitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Altitude
        {
            get
            {
                return null;
            }
        }

        /// <summary>Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#certificate DnsRecord#certificate}
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Digest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#digest DnsRecord#digest}
        /// </remarks>
        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Digest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Digest Type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#digest_type DnsRecord#digest_type}
        /// </remarks>
        [JsiiProperty(name: "digestType", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DigestType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Fingerprint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#fingerprint DnsRecord#fingerprint}
        /// </remarks>
        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Fingerprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Flags for the CAA record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#flags DnsRecord#flags}
        /// </remarks>
        [JsiiProperty(name: "flags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? Flags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Key Tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#key_tag DnsRecord#key_tag}
        /// </remarks>
        [JsiiProperty(name: "keyTag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeyTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Degrees of latitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#lat_degrees DnsRecord#lat_degrees}
        /// </remarks>
        [JsiiProperty(name: "latDegrees", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LatDegrees
        {
            get
            {
                return null;
            }
        }

        /// <summary>Latitude direction. Available values: "N", "S".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#lat_direction DnsRecord#lat_direction}
        /// </remarks>
        [JsiiProperty(name: "latDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LatDirection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minutes of latitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#lat_minutes DnsRecord#lat_minutes}
        /// </remarks>
        [JsiiProperty(name: "latMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LatMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Seconds of latitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#lat_seconds DnsRecord#lat_seconds}
        /// </remarks>
        [JsiiProperty(name: "latSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LatSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Degrees of longitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#long_degrees DnsRecord#long_degrees}
        /// </remarks>
        [JsiiProperty(name: "longDegrees", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LongDegrees
        {
            get
            {
                return null;
            }
        }

        /// <summary>Longitude direction. Available values: "E", "W".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#long_direction DnsRecord#long_direction}
        /// </remarks>
        [JsiiProperty(name: "longDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LongDirection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minutes of longitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#long_minutes DnsRecord#long_minutes}
        /// </remarks>
        [JsiiProperty(name: "longMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LongMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Seconds of longitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#long_seconds DnsRecord#long_seconds}
        /// </remarks>
        [JsiiProperty(name: "longSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LongSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Matching Type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#matching_type DnsRecord#matching_type}
        /// </remarks>
        [JsiiProperty(name: "matchingType", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MatchingType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Order.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#order DnsRecord#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Order
        {
            get
            {
                return null;
            }
        }

        /// <summary>The port of the service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#port DnsRecord#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Horizontal precision of location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#precision_horz DnsRecord#precision_horz}
        /// </remarks>
        [JsiiProperty(name: "precisionHorz", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PrecisionHorz
        {
            get
            {
                return null;
            }
        }

        /// <summary>Vertical precision of location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#precision_vert DnsRecord#precision_vert}
        /// </remarks>
        [JsiiProperty(name: "precisionVert", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PrecisionVert
        {
            get
            {
                return null;
            }
        }

        /// <summary>Preference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#preference DnsRecord#preference}
        /// </remarks>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Preference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Priority.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#priority DnsRecord#priority}
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#protocol DnsRecord#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Public Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#public_key DnsRecord#public_key}
        /// </remarks>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Regex.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#regex DnsRecord#regex}
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Regex
        {
            get
            {
                return null;
            }
        }

        /// <summary>Replacement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#replacement DnsRecord#replacement}
        /// </remarks>
        [JsiiProperty(name: "replacement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Replacement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selector.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#selector DnsRecord#selector}
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Selector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#service DnsRecord#service}
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Service
        {
            get
            {
                return null;
            }
        }

        /// <summary>Size of location in meters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#size DnsRecord#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Size
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the property controlled by this record (e.g.: issue, issuewild, iodef).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#tag DnsRecord#tag}
        /// </remarks>
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#target DnsRecord#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#type DnsRecord#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#usage DnsRecord#usage}
        /// </remarks>
        [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Usage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Value of the record. This field's semantics depend on the chosen tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#value DnsRecord#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        /// <summary>The record weight.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#weight DnsRecord#weight}
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsRecordData), fullyQualifiedName: "cloudflare.dnsRecord.DnsRecordData")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DnsRecord.IDnsRecordData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Algorithm.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#algorithm DnsRecord#algorithm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Algorithm
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Altitude of location in meters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#altitude DnsRecord#altitude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "altitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Altitude
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#certificate DnsRecord#certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Certificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Digest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#digest DnsRecord#digest}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Digest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Digest Type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#digest_type DnsRecord#digest_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "digestType", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DigestType
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Fingerprint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#fingerprint DnsRecord#fingerprint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fingerprint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Flags for the CAA record.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#flags DnsRecord#flags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? Flags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>Key Tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#key_tag DnsRecord#key_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyTag", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeyTag
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Degrees of latitude.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#lat_degrees DnsRecord#lat_degrees}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latDegrees", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LatDegrees
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Latitude direction. Available values: "N", "S".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#lat_direction DnsRecord#lat_direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LatDirection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Minutes of latitude.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#lat_minutes DnsRecord#lat_minutes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LatMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Seconds of latitude.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#lat_seconds DnsRecord#lat_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LatSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Degrees of longitude.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#long_degrees DnsRecord#long_degrees}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "longDegrees", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LongDegrees
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Longitude direction. Available values: "E", "W".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#long_direction DnsRecord#long_direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "longDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LongDirection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Minutes of longitude.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#long_minutes DnsRecord#long_minutes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "longMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LongMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Seconds of longitude.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#long_seconds DnsRecord#long_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "longSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LongSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Matching Type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#matching_type DnsRecord#matching_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchingType", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MatchingType
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Order.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#order DnsRecord#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The port of the service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#port DnsRecord#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Horizontal precision of location.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#precision_horz DnsRecord#precision_horz}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "precisionHorz", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PrecisionHorz
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Vertical precision of location.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#precision_vert DnsRecord#precision_vert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "precisionVert", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PrecisionVert
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Preference.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#preference DnsRecord#preference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Preference
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Priority.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#priority DnsRecord#priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Protocol.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#protocol DnsRecord#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Protocol
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Public Key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#public_key DnsRecord#public_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Regex.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#regex DnsRecord#regex}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Regex
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Replacement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#replacement DnsRecord#replacement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replacement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Replacement
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selector.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#selector DnsRecord#selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Selector
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#service DnsRecord#service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Service
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Size of location in meters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#size DnsRecord#size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Size
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Name of the property controlled by this record (e.g.: issue, issuewild, iodef).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#tag DnsRecord#tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Target.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#target DnsRecord#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#type DnsRecord#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Type
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Usage.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#usage DnsRecord#usage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Usage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Value of the record. This field's semantics depend on the chosen tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#value DnsRecord#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The record weight.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/dns_record#weight DnsRecord#weight}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
