using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevCenterAttachedNetwork
{
    [JsiiInterface(nativeType: typeof(IDevCenterAttachedNetworkTimeouts), fullyQualifiedName: "azurerm.devCenterAttachedNetwork.DevCenterAttachedNetworkTimeouts")]
    public interface IDevCenterAttachedNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dev_center_attached_network#create DevCenterAttachedNetwork#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dev_center_attached_network#delete DevCenterAttachedNetwork#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dev_center_attached_network#read DevCenterAttachedNetwork#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevCenterAttachedNetworkTimeouts), fullyQualifiedName: "azurerm.devCenterAttachedNetwork.DevCenterAttachedNetworkTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevCenterAttachedNetwork.IDevCenterAttachedNetworkTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dev_center_attached_network#create DevCenterAttachedNetwork#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dev_center_attached_network#delete DevCenterAttachedNetwork#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dev_center_attached_network#read DevCenterAttachedNetwork#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
