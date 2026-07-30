using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningInferenceCluster
{
    [JsiiByValue(fqn: "azurerm.machineLearningInferenceCluster.MachineLearningInferenceClusterSsl")]
    public class MachineLearningInferenceClusterSsl : azurerm.MachineLearningInferenceCluster.IMachineLearningInferenceClusterSsl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_inference_cluster#cert MachineLearningInferenceCluster#cert}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cert
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_inference_cluster#cname MachineLearningInferenceCluster#cname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_inference_cluster#key MachineLearningInferenceCluster#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_inference_cluster#leaf_domain_label MachineLearningInferenceCluster#leaf_domain_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "leafDomainLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LeafDomainLabel
        {
            get;
            set;
        }

        private object? _overwriteExistingDomain;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/machine_learning_inference_cluster#overwrite_existing_domain MachineLearningInferenceCluster#overwrite_existing_domain}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overwriteExistingDomain", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OverwriteExistingDomain
        {
            get => _overwriteExistingDomain;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _overwriteExistingDomain = value;
            }
        }
    }
}
