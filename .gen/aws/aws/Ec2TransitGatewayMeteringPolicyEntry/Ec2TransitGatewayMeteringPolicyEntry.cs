using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2TransitGatewayMeteringPolicyEntry
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ec2_transit_gateway_metering_policy_entry aws_ec2_transit_gateway_metering_policy_entry}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntry), fullyQualifiedName: "aws.ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntry", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntryConfig\"}}]")]
    public class Ec2TransitGatewayMeteringPolicyEntry : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ec2_transit_gateway_metering_policy_entry aws_ec2_transit_gateway_metering_policy_entry} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Ec2TransitGatewayMeteringPolicyEntry(Constructs.Construct scope, string id, aws.Ec2TransitGatewayMeteringPolicyEntry.IEc2TransitGatewayMeteringPolicyEntryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Ec2TransitGatewayMeteringPolicyEntry.IEc2TransitGatewayMeteringPolicyEntryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TransitGatewayMeteringPolicyEntry(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TransitGatewayMeteringPolicyEntry(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Ec2TransitGatewayMeteringPolicyEntry resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Ec2TransitGatewayMeteringPolicyEntry to import.</param>
        /// <param name="importFromId">The id of the existing Ec2TransitGatewayMeteringPolicyEntry that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Ec2TransitGatewayMeteringPolicyEntry to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Ec2TransitGatewayMeteringPolicyEntry to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ec2_transit_gateway_metering_policy_entry#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Ec2TransitGatewayMeteringPolicyEntry that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Ec2TransitGatewayMeteringPolicyEntry to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.Ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntry), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntryTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ec2TransitGatewayMeteringPolicyEntry.IEc2TransitGatewayMeteringPolicyEntryTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2TransitGatewayMeteringPolicyEntry.IEc2TransitGatewayMeteringPolicyEntryTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationCidrBlock")]
        public virtual void ResetDestinationCidrBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationPortRange")]
        public virtual void ResetDestinationPortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationTransitGatewayAttachmentId")]
        public virtual void ResetDestinationTransitGatewayAttachmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationTransitGatewayAttachmentType")]
        public virtual void ResetDestinationTransitGatewayAttachmentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceCidrBlock")]
        public virtual void ResetSourceCidrBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePortRange")]
        public virtual void ResetSourcePortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceTransitGatewayAttachmentId")]
        public virtual void ResetSourceTransitGatewayAttachmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceTransitGatewayAttachmentType")]
        public virtual void ResetSourceTransitGatewayAttachmentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntry))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntryTimeoutsOutputReference\"}")]
        public virtual aws.Ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntryTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntryTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationCidrBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationCidrBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRangeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationPortRangeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationTransitGatewayAttachmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationTransitGatewayAttachmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationTransitGatewayAttachmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationTransitGatewayAttachmentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "meteredAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MeteredAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyRuleNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PolicyRuleNumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
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
        [JsiiProperty(name: "sourceCidrBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceCidrBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourcePortRangeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTransitGatewayAttachmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTransitGatewayAttachmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTransitGatewayAttachmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTransitGatewayAttachmentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.ec2TransitGatewayMeteringPolicyEntry.Ec2TransitGatewayMeteringPolicyEntryTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayMeteringPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransitGatewayMeteringPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationPortRange
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationTransitGatewayAttachmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationTransitGatewayAttachmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationTransitGatewayAttachmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationTransitGatewayAttachmentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "meteredAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MeteredAccount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyRuleNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PolicyRuleNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
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

        [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourcePortRange
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceTransitGatewayAttachmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceTransitGatewayAttachmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceTransitGatewayAttachmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceTransitGatewayAttachmentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transitGatewayMeteringPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitGatewayMeteringPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
