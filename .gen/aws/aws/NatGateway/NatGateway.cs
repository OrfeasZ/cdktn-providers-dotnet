using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NatGateway
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/nat_gateway aws_nat_gateway}.</summary>
    [JsiiClass(nativeType: typeof(aws.NatGateway.NatGateway), fullyQualifiedName: "aws.natGateway.NatGateway", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.natGateway.NatGatewayConfig\"}}]")]
    public class NatGateway : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/nat_gateway aws_nat_gateway} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NatGateway(Constructs.Construct scope, string id, aws.NatGateway.INatGatewayConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.NatGateway.INatGatewayConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NatGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NatGateway(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NatGateway resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NatGateway to import.</param>
        /// <param name="importFromId">The id of the existing NatGateway that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NatGateway to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NatGateway to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/nat_gateway#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NatGateway that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NatGateway to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.NatGateway.NatGateway), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAvailabilityZoneAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.natGateway.NatGatewayAvailabilityZoneAddress\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAvailabilityZoneAddress(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.NatGateway.INatGatewayAvailabilityZoneAddress[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NatGateway.INatGatewayAvailabilityZoneAddress).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NatGateway.INatGatewayAvailabilityZoneAddress).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.natGateway.NatGatewayTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.NatGateway.INatGatewayTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.NatGateway.INatGatewayTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllocationId")]
        public virtual void ResetAllocationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityMode")]
        public virtual void ResetAvailabilityMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityZoneAddress")]
        public virtual void ResetAvailabilityZoneAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectivityType")]
        public virtual void ResetConnectivityType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIp")]
        public virtual void ResetPrivateIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryAllocationIds")]
        public virtual void ResetSecondaryAllocationIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryPrivateIpAddressCount")]
        public virtual void ResetSecondaryPrivateIpAddressCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryPrivateIpAddresses")]
        public virtual void ResetSecondaryPrivateIpAddresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcId")]
        public virtual void ResetVpcId()
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
        = GetStaticProperty<string>(typeof(aws.NatGateway.NatGateway))!;

        [JsiiProperty(name: "associationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoProvisionZones", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoProvisionZones
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoScalingIps", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingIps
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZoneAddress", typeJson: "{\"fqn\":\"aws.natGateway.NatGatewayAvailabilityZoneAddressList\"}")]
        public virtual aws.NatGateway.NatGatewayAvailabilityZoneAddressList AvailabilityZoneAddress
        {
            get => GetInstanceProperty<aws.NatGateway.NatGatewayAvailabilityZoneAddressList>()!;
        }

        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkInterfaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionalNatGatewayAddress", typeJson: "{\"fqn\":\"aws.natGateway.NatGatewayRegionalNatGatewayAddressList\"}")]
        public virtual aws.NatGateway.NatGatewayRegionalNatGatewayAddressList RegionalNatGatewayAddress
        {
            get => GetInstanceProperty<aws.NatGateway.NatGatewayRegionalNatGatewayAddressList>()!;
        }

        [JsiiProperty(name: "regionalNatGatewayAutoMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalNatGatewayAutoMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteTableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.natGateway.NatGatewayTimeoutsOutputReference\"}")]
        public virtual aws.NatGateway.NatGatewayTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.NatGateway.NatGatewayTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllocationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneAddressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.natGateway.NatGatewayAvailabilityZoneAddress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AvailabilityZoneAddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectivityTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectivityTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryAllocationIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecondaryAllocationIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryPrivateIpAddressCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SecondaryPrivateIpAddressCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryPrivateIpAddressesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecondaryPrivateIpAddressesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.natGateway.NatGatewayTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllocationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "availabilityMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectivityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectivityType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIp
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

        [JsiiProperty(name: "secondaryAllocationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecondaryAllocationIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryPrivateIpAddressCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SecondaryPrivateIpAddressCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryPrivateIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecondaryPrivateIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
