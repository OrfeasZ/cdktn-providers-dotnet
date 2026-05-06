using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiInterface(nativeType: typeof(IApmConfigConfigDimensions), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigDimensions")]
    public interface IApmConfigConfigDimensions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#name ApmConfigConfig#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#value_source ApmConfigConfig#value_source}.</summary>
        [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValueSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmConfigConfigDimensions), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigDimensions")]
        internal sealed class _Proxy : DeputyBase, oci.ApmConfigConfig.IApmConfigConfigDimensions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#name ApmConfigConfig#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#value_source ApmConfigConfig#value_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValueSource
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
