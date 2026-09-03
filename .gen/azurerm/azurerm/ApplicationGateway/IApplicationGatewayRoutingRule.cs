using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayRoutingRule), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRoutingRule")]
    public interface IApplicationGatewayRoutingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#backend_address_pool_name ApplicationGateway#backend_address_pool_name}.</summary>
        [JsiiProperty(name: "backendAddressPoolName", typeJson: "{\"primitive\":\"string\"}")]
        string BackendAddressPoolName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#backend_name ApplicationGateway#backend_name}.</summary>
        [JsiiProperty(name: "backendName", typeJson: "{\"primitive\":\"string\"}")]
        string BackendName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#listener_name ApplicationGateway#listener_name}.</summary>
        [JsiiProperty(name: "listenerName", typeJson: "{\"primitive\":\"string\"}")]
        string ListenerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#priority ApplicationGateway#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayRoutingRule), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRoutingRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayRoutingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#backend_address_pool_name ApplicationGateway#backend_address_pool_name}.</summary>
            [JsiiProperty(name: "backendAddressPoolName", typeJson: "{\"primitive\":\"string\"}")]
            public string BackendAddressPoolName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#backend_name ApplicationGateway#backend_name}.</summary>
            [JsiiProperty(name: "backendName", typeJson: "{\"primitive\":\"string\"}")]
            public string BackendName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#listener_name ApplicationGateway#listener_name}.</summary>
            [JsiiProperty(name: "listenerName", typeJson: "{\"primitive\":\"string\"}")]
            public string ListenerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/application_gateway#priority ApplicationGateway#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
