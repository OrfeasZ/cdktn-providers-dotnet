using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2CapacityBlockReservation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/data-sources/ec2_capacity_block_reservation aws_ec2_capacity_block_reservation}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservation), fullyQualifiedName: "aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationConfig\"}}]")]
    public class DataAwsEc2CapacityBlockReservation : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/data-sources/ec2_capacity_block_reservation aws_ec2_capacity_block_reservation} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEc2CapacityBlockReservation(Constructs.Construct scope, string id, aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2CapacityBlockReservation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2CapacityBlockReservation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsEc2CapacityBlockReservation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsEc2CapacityBlockReservation to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsEc2CapacityBlockReservation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsEc2CapacityBlockReservation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsEc2CapacityBlockReservation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/data-sources/ec2_capacity_block_reservation#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsEc2CapacityBlockReservation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsEc2CapacityBlockReservation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservation))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availableInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableInstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "capacityBlockId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityBlockId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commitmentInfo", typeJson: "{\"fqn\":\"aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationCommitmentInfoOutputReference\"}")]
        public virtual aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationCommitmentInfoOutputReference CommitmentInfo
        {
            get => GetInstanceProperty<aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationCommitmentInfoOutputReference>()!;
        }

        [JsiiProperty(name: "createdDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deliveryPreference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeliveryPreference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EbsOptimized
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endDateType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndDateType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationFilterList\"}")]
        public virtual aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationFilterList Filter
        {
            get => GetInstanceProperty<aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationFilterList>()!;
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceMatchCriteria", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceMatchCriteria
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instancePlatform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstancePlatform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "interruptibleCapacityAllocation", typeJson: "{\"fqn\":\"aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationInterruptibleCapacityAllocationOutputReference\"}")]
        public virtual aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationInterruptibleCapacityAllocationOutputReference InterruptibleCapacityAllocation
        {
            get => GetInstanceProperty<aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationInterruptibleCapacityAllocationOutputReference>()!;
        }

        [JsiiProperty(name: "interruptionInfo", typeJson: "{\"fqn\":\"aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationInterruptionInfoOutputReference\"}")]
        public virtual aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationInterruptionInfoOutputReference InterruptionInfo
        {
            get => GetInstanceProperty<aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationInterruptionInfoOutputReference>()!;
        }

        [JsiiProperty(name: "outpostArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutpostArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroupArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reservationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReservationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tenancy
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
