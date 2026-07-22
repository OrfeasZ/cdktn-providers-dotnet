using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrInstanceFleet
{
    [JsiiInterface(nativeType: typeof(IEmrInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emrInstanceFleet.EmrInstanceFleetLaunchSpecifications")]
    public interface IEmrInstanceFleetLaunchSpecifications
    {
        /// <summary>on_demand_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/emr_instance_fleet#on_demand_specification EmrInstanceFleet#on_demand_specification}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EmrInstanceFleet.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrInstanceFleet.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/emr_instance_fleet#spot_specification EmrInstanceFleet#spot_specification}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EmrInstanceFleet.IEmrInstanceFleetLaunchSpecificationsSpotSpecification" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "spotSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrInstanceFleet.EmrInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SpotSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrInstanceFleetLaunchSpecifications), fullyQualifiedName: "aws.emrInstanceFleet.EmrInstanceFleetLaunchSpecifications")]
        internal sealed class _Proxy : DeputyBase, aws.EmrInstanceFleet.IEmrInstanceFleetLaunchSpecifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_demand_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/emr_instance_fleet#on_demand_specification EmrInstanceFleet#on_demand_specification}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EmrInstanceFleet.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrInstanceFleet.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OnDemandSpecification
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>spot_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/emr_instance_fleet#spot_specification EmrInstanceFleet#spot_specification}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EmrInstanceFleet.IEmrInstanceFleetLaunchSpecificationsSpotSpecification" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spotSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrInstanceFleet.EmrInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SpotSpecification
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
