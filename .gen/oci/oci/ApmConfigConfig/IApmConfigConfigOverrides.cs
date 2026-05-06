using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiInterface(nativeType: typeof(IApmConfigConfigOverrides), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigOverrides")]
    public interface IApmConfigConfigOverrides
    {
        /// <summary>override_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#override_list ApmConfigConfig#override_list}
        /// </remarks>
        [JsiiProperty(name: "overrideList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigOverridesOverrideListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OverrideList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmConfigConfigOverrides), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigOverrides")]
        internal sealed class _Proxy : DeputyBase, oci.ApmConfigConfig.IApmConfigConfigOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>override_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#override_list ApmConfigConfig#override_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigOverridesOverrideListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OverrideList
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
