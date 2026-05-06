using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiInterface(nativeType: typeof(IApmConfigConfigConfigA), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigConfigA")]
    public interface IApmConfigConfigConfigA
    {
        /// <summary>config_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#config_map ApmConfigConfig#config_map}
        /// </remarks>
        [JsiiProperty(name: "configMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigConfigConfigMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConfigMap
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmConfigConfigConfigA), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigConfigA")]
        internal sealed class _Proxy : DeputyBase, oci.ApmConfigConfig.IApmConfigConfigConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>config_map block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#config_map ApmConfigConfig#config_map}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigConfigConfigMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConfigMap
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
