using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DirectoryServiceIpRoutesExclusive
{
    [JsiiByValue(fqn: "aws.directoryServiceIpRoutesExclusive.DirectoryServiceIpRoutesExclusiveIpRoute")]
    public class DirectoryServiceIpRoutesExclusiveIpRoute : aws.DirectoryServiceIpRoutesExclusive.IDirectoryServiceIpRoutesExclusiveIpRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/directory_service_ip_routes_exclusive#cidr_ip DirectoryServiceIpRoutesExclusive#cidr_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidrIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CidrIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/directory_service_ip_routes_exclusive#cidr_ipv6 DirectoryServiceIpRoutesExclusive#cidr_ipv6}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidrIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CidrIpv6
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/directory_service_ip_routes_exclusive#description DirectoryServiceIpRoutesExclusive#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
