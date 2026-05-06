using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiByValue(fqn: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptions")]
    public class CoreInstanceConfigurationInstanceDetailsOptions : oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptions
    {
        private object? _blockVolumes;

        /// <summary>block_volumes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#block_volumes CoreInstanceConfiguration#block_volumes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockVolumes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BlockVolumes
        {
            get => _blockVolumes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _blockVolumes = value;
            }
        }

        /// <summary>launch_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#launch_details CoreInstanceConfiguration#launch_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsLaunchDetails\"}", isOptional: true)]
        public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsLaunchDetails? LaunchDetails
        {
            get;
            set;
        }

        private object? _secondaryVnics;

        /// <summary>secondary_vnics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#secondary_vnics CoreInstanceConfiguration#secondary_vnics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryVnics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecondaryVnics
        {
            get => _secondaryVnics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnics[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnics).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secondaryVnics = value;
            }
        }
    }
}
