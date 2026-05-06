using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiByValue(fqn: "oci.apmConfigConfig.ApmConfigConfigConfigA")]
    public class ApmConfigConfigConfigA : oci.ApmConfigConfig.IApmConfigConfigConfigA
    {
        private object? _configMap;

        /// <summary>config_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#config_map ApmConfigConfig#config_map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmConfigConfig.ApmConfigConfigConfigConfigMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ConfigMap
        {
            get => _configMap;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApmConfigConfig.IApmConfigConfigConfigConfigMap[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmConfigConfig.IApmConfigConfigConfigConfigMap).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _configMap = value;
            }
        }
    }
}
