using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultRouteTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreDefaultRouteTable.CoreDefaultRouteTableRouteRules")]
    public class CoreDefaultRouteTableRouteRules : oci.CoreDefaultRouteTable.ICoreDefaultRouteTableRouteRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#network_entity_id CoreDefaultRouteTable#network_entity_id}.</summary>
        [JsiiProperty(name: "networkEntityId", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkEntityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#cidr_block CoreDefaultRouteTable#cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#description CoreDefaultRouteTable#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#destination CoreDefaultRouteTable#destination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#destination_type CoreDefaultRouteTable#destination_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#route_type CoreDefaultRouteTable#route_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RouteType
        {
            get;
            set;
        }
    }
}
