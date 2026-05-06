using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePreemptibleInstanceConfigPreemptionAction), fullyQualifiedName: "oci.coreInstance.CoreInstancePreemptibleInstanceConfigPreemptionAction")]
    public interface ICoreInstancePreemptibleInstanceConfigPreemptionAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#type CoreInstance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#preserve_boot_volume CoreInstance#preserve_boot_volume}.</summary>
        [JsiiProperty(name: "preserveBootVolume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreserveBootVolume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePreemptibleInstanceConfigPreemptionAction), fullyQualifiedName: "oci.coreInstance.CoreInstancePreemptibleInstanceConfigPreemptionAction")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstance.ICoreInstancePreemptibleInstanceConfigPreemptionAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#type CoreInstance#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#preserve_boot_volume CoreInstance#preserve_boot_volume}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preserveBootVolume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreserveBootVolume
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
