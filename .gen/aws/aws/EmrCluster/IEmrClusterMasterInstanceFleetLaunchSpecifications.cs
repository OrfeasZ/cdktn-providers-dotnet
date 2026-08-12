using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiInterface(nativeType: typeof(IEmrClusterMasterInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecifications")]
    public interface IEmrClusterMasterInstanceFleetLaunchSpecifications
    {
        /// <summary>on_demand_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/emr_cluster#on_demand_specification EmrCluster#on_demand_specification}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnDemandSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>spot_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/emr_cluster#spot_specification EmrCluster#spot_specification}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "spotSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SpotSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterMasterInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecifications")]
        internal sealed class _Proxy : DeputyBase, aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_demand_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/emr_cluster#on_demand_specification EmrCluster#on_demand_specification}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OnDemandSpecification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>spot_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/emr_cluster#spot_specification EmrCluster#spot_specification}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spotSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SpotSpecification
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
