using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultRouteTable
{
    [JsiiInterface(nativeType: typeof(ICoreDefaultRouteTableRouteRules), fullyQualifiedName: "oci.coreDefaultRouteTable.CoreDefaultRouteTableRouteRules")]
    public interface ICoreDefaultRouteTableRouteRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#network_entity_id CoreDefaultRouteTable#network_entity_id}.</summary>
        [JsiiProperty(name: "networkEntityId", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkEntityId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#cidr_block CoreDefaultRouteTable#cidr_block}.</summary>
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CidrBlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#description CoreDefaultRouteTable#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#destination CoreDefaultRouteTable#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Destination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#destination_type CoreDefaultRouteTable#destination_type}.</summary>
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#route_type CoreDefaultRouteTable#route_type}.</summary>
        [JsiiProperty(name: "routeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreDefaultRouteTableRouteRules), fullyQualifiedName: "oci.coreDefaultRouteTable.CoreDefaultRouteTableRouteRules")]
        internal sealed class _Proxy : DeputyBase, oci.CoreDefaultRouteTable.ICoreDefaultRouteTableRouteRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#network_entity_id CoreDefaultRouteTable#network_entity_id}.</summary>
            [JsiiProperty(name: "networkEntityId", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkEntityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#cidr_block CoreDefaultRouteTable#cidr_block}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CidrBlock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#description CoreDefaultRouteTable#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#destination CoreDefaultRouteTable#destination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Destination
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#destination_type CoreDefaultRouteTable#destination_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_route_table#route_type CoreDefaultRouteTable#route_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
