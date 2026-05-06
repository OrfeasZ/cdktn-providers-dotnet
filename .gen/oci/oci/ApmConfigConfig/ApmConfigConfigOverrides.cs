using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiByValue(fqn: "oci.apmConfigConfig.ApmConfigConfigOverrides")]
    public class ApmConfigConfigOverrides : oci.ApmConfigConfig.IApmConfigConfigOverrides
    {
        private object? _overrideList;

        /// <summary>override_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#override_list ApmConfigConfig#override_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrideList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigOverridesOverrideListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OverrideList
        {
            get => _overrideList;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApmConfigConfig.IApmConfigConfigOverridesOverrideListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmConfigConfig.IApmConfigConfigOverridesOverrideListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _overrideList = value;
            }
        }
    }
}
