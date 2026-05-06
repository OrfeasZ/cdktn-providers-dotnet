using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiOpsiConfiguration
{
    [JsiiInterface(nativeType: typeof(IOpsiOpsiConfigurationConfigItems), fullyQualifiedName: "oci.opsiOpsiConfiguration.OpsiOpsiConfigurationConfigItems")]
    public interface IOpsiOpsiConfigurationConfigItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_opsi_configuration#config_item_type OpsiOpsiConfiguration#config_item_type}.</summary>
        [JsiiProperty(name: "configItemType", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigItemType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_opsi_configuration#name OpsiOpsiConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_opsi_configuration#value OpsiOpsiConfiguration#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsiOpsiConfigurationConfigItems), fullyQualifiedName: "oci.opsiOpsiConfiguration.OpsiOpsiConfigurationConfigItems")]
        internal sealed class _Proxy : DeputyBase, oci.OpsiOpsiConfiguration.IOpsiOpsiConfigurationConfigItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_opsi_configuration#config_item_type OpsiOpsiConfiguration#config_item_type}.</summary>
            [JsiiProperty(name: "configItemType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigItemType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_opsi_configuration#name OpsiOpsiConfiguration#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_opsi_configuration#value OpsiOpsiConfiguration#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
