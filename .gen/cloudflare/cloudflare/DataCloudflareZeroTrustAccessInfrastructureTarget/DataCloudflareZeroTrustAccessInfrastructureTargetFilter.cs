using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessInfrastructureTarget
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustAccessInfrastructureTarget.DataCloudflareZeroTrustAccessInfrastructureTargetFilter")]
    public class DataCloudflareZeroTrustAccessInfrastructureTargetFilter : cloudflare.DataCloudflareZeroTrustAccessInfrastructureTarget.IDataCloudflareZeroTrustAccessInfrastructureTargetFilter
    {
        /// <summary>Date and time at which the target was created after (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#created_after DataCloudflareZeroTrustAccessInfrastructureTarget#created_after}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createdAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedAfter
        {
            get;
            set;
        }

        /// <summary>Date and time at which the target was created before (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#created_before DataCloudflareZeroTrustAccessInfrastructureTarget#created_before}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createdBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedBefore
        {
            get;
            set;
        }

        /// <summary>The sorting direction. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#direction DataCloudflareZeroTrustAccessInfrastructureTarget#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Hostname of a target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#hostname DataCloudflareZeroTrustAccessInfrastructureTarget#hostname}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>Partial match to the hostname of a target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#hostname_contains DataCloudflareZeroTrustAccessInfrastructureTarget#hostname_contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostnameContains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostnameContains
        {
            get;
            set;
        }

        /// <summary>Filters for targets whose IP addresses look like the specified string. Supports `*` as a wildcard character.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#ip_like DataCloudflareZeroTrustAccessInfrastructureTarget#ip_like}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipLike", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpLike
        {
            get;
            set;
        }

        /// <summary>Filters for targets that have any of the following IP addresses.</summary>
        /// <remarks>
        /// Specify
        /// <c>ips</c> multiple times in query parameter to build list of candidates.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#ips DataCloudflareZeroTrustAccessInfrastructureTarget#ips}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ips
        {
            get;
            set;
        }

        /// <summary>IPv4 address of the target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#ip_v4 DataCloudflareZeroTrustAccessInfrastructureTarget#ip_v4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipV4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpV4
        {
            get;
            set;
        }

        /// <summary>Defines an IPv4 filter range's ending value (inclusive). Requires `ipv4_start` to be specified as well.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#ipv4_end DataCloudflareZeroTrustAccessInfrastructureTarget#ipv4_end}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4End", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv4End
        {
            get;
            set;
        }

        /// <summary>Defines an IPv4 filter range's starting value (inclusive). Requires `ipv4_end` to be specified as well.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#ipv4_start DataCloudflareZeroTrustAccessInfrastructureTarget#ipv4_start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4Start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv4Start
        {
            get;
            set;
        }

        /// <summary>IPv6 address of the target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#ip_v6 DataCloudflareZeroTrustAccessInfrastructureTarget#ip_v6}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipV6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpV6
        {
            get;
            set;
        }

        /// <summary>Defines an IPv6 filter range's ending value (inclusive). Requires `ipv6_start` to be specified as well.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#ipv6_end DataCloudflareZeroTrustAccessInfrastructureTarget#ipv6_end}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6End", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6End
        {
            get;
            set;
        }

        /// <summary>Defines an IPv6 filter range's starting value (inclusive). Requires `ipv6_end` to be specified as well.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#ipv6_start DataCloudflareZeroTrustAccessInfrastructureTarget#ipv6_start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6Start
        {
            get;
            set;
        }

        /// <summary>Date and time at which the target was modified after (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#modified_after DataCloudflareZeroTrustAccessInfrastructureTarget#modified_after}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifiedAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModifiedAfter
        {
            get;
            set;
        }

        /// <summary>Date and time at which the target was modified before (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#modified_before DataCloudflareZeroTrustAccessInfrastructureTarget#modified_before}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modifiedBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModifiedBefore
        {
            get;
            set;
        }

        /// <summary>The field to sort by. Available values: "hostname", "created_at".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#order DataCloudflareZeroTrustAccessInfrastructureTarget#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }

        /// <summary>Filters for targets that have any of the following UUIDs.</summary>
        /// <remarks>
        /// Specify
        /// <c>target_ids</c> multiple times in query parameter to build list of
        /// candidates.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#target_ids DataCloudflareZeroTrustAccessInfrastructureTarget#target_ids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetIds
        {
            get;
            set;
        }

        /// <summary>Private virtual network identifier of the target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_access_infrastructure_target#virtual_network_id DataCloudflareZeroTrustAccessInfrastructureTarget#virtual_network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualNetworkId
        {
            get;
            set;
        }
    }
}
