using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackGenai")]
    public class DifStackGenai : oci.DifStack.IDifStackGenai
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#base_model DifStack#base_model}.</summary>
        [JsiiProperty(name: "baseModel", typeJson: "{\"primitive\":\"string\"}")]
        public string BaseModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#cluster_type DifStack#cluster_type}.</summary>
        [JsiiProperty(name: "clusterType", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#oci_region DifStack#oci_region}.</summary>
        [JsiiProperty(name: "ociRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string OciRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#unit_count DifStack#unit_count}.</summary>
        [JsiiProperty(name: "unitCount", typeJson: "{\"primitive\":\"number\"}")]
        public double UnitCount
        {
            get;
            set;
        }

        private object? _endpoints;

        /// <summary>endpoints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/dif_stack#endpoints DifStack#endpoints}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGenaiEndpoints" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGenaiEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Endpoints
        {
            get => _endpoints;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DifStack.IDifStackGenaiEndpoints[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackGenaiEndpoints).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _endpoints = value;
            }
        }
    }
}
