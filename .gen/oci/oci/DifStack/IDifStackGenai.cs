using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackGenai), fullyQualifiedName: "oci.difStack.DifStackGenai")]
    public interface IDifStackGenai
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#base_model DifStack#base_model}.</summary>
        [JsiiProperty(name: "baseModel", typeJson: "{\"primitive\":\"string\"}")]
        string BaseModel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#cluster_type DifStack#cluster_type}.</summary>
        [JsiiProperty(name: "clusterType", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#oci_region DifStack#oci_region}.</summary>
        [JsiiProperty(name: "ociRegion", typeJson: "{\"primitive\":\"string\"}")]
        string OciRegion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#unit_count DifStack#unit_count}.</summary>
        [JsiiProperty(name: "unitCount", typeJson: "{\"primitive\":\"number\"}")]
        double UnitCount
        {
            get;
        }

        /// <summary>endpoints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#endpoints DifStack#endpoints}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGenaiEndpoints" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGenaiEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Endpoints
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackGenai), fullyQualifiedName: "oci.difStack.DifStackGenai")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackGenai
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#base_model DifStack#base_model}.</summary>
            [JsiiProperty(name: "baseModel", typeJson: "{\"primitive\":\"string\"}")]
            public string BaseModel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#cluster_type DifStack#cluster_type}.</summary>
            [JsiiProperty(name: "clusterType", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#oci_region DifStack#oci_region}.</summary>
            [JsiiProperty(name: "ociRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string OciRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#unit_count DifStack#unit_count}.</summary>
            [JsiiProperty(name: "unitCount", typeJson: "{\"primitive\":\"number\"}")]
            public double UnitCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>endpoints block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/dif_stack#endpoints DifStack#endpoints}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackGenaiEndpoints" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackGenaiEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Endpoints
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
