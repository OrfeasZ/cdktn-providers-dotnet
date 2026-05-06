using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsBuildPipeline.DevopsBuildPipelineBuildPipelineParameters")]
    public class DevopsBuildPipelineBuildPipelineParameters : oci.DevopsBuildPipeline.IDevopsBuildPipelineBuildPipelineParameters
    {
        private object _items;

        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline#items DevopsBuildPipeline#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsBuildPipeline.DevopsBuildPipelineBuildPipelineParametersItems\"},\"kind\":\"array\"}}]}}")]
        public object Items
        {
            get => _items;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DevopsBuildPipeline.IDevopsBuildPipelineBuildPipelineParametersItems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DevopsBuildPipeline.IDevopsBuildPipelineBuildPipelineParametersItems).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DevopsBuildPipeline.IDevopsBuildPipelineBuildPipelineParametersItems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _items = value;
            }
        }
    }
}
