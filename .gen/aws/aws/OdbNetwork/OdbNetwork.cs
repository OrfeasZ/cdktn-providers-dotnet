using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbNetwork
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_network aws_odb_network}.</summary>
    [JsiiClass(nativeType: typeof(aws.OdbNetwork.OdbNetwork), fullyQualifiedName: "aws.odbNetwork.OdbNetwork", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.odbNetwork.OdbNetworkConfig\"}}]")]
    public class OdbNetwork : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_network aws_odb_network} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OdbNetwork(Constructs.Construct scope, string id, aws.OdbNetwork.IOdbNetworkConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.OdbNetwork.IOdbNetworkConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OdbNetwork(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OdbNetwork(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OdbNetwork resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OdbNetwork to import.</param>
        /// <param name="importFromId">The id of the existing OdbNetwork that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OdbNetwork to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OdbNetwork to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_network#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OdbNetwork that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OdbNetwork to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.OdbNetwork.OdbNetwork), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.odbNetwork.OdbNetworkTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.OdbNetwork.IOdbNetworkTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OdbNetwork.IOdbNetworkTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilityZone")]
        public virtual void ResetAvailabilityZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCrossRegionS3RestoreSourcesAccess")]
        public virtual void ResetCrossRegionS3RestoreSourcesAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomDomainName")]
        public virtual void ResetCustomDomainName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultDnsPrefix")]
        public virtual void ResetDefaultDnsPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteAssociatedResources")]
        public virtual void ResetDeleteAssociatedResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsAccess")]
        public virtual void ResetKmsAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsPolicyDocument")]
        public virtual void ResetKmsPolicyDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3PolicyDocument")]
        public virtual void ResetS3PolicyDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStsAccess")]
        public virtual void ResetStsAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStsPolicyDocument")]
        public virtual void ResetStsPolicyDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.OdbNetwork.OdbNetwork))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedServices", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkManagedServicesList\"}")]
        public virtual aws.OdbNetwork.OdbNetworkManagedServicesList ManagedServices
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkManagedServicesList>()!;
        }

        [JsiiProperty(name: "ociDnsForwardingConfigs", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkOciDnsForwardingConfigsList\"}")]
        public virtual aws.OdbNetwork.OdbNetworkOciDnsForwardingConfigsList OciDnsForwardingConfigs
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkOciDnsForwardingConfigsList>()!;
        }

        [JsiiProperty(name: "ociNetworkAnchorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciNetworkAnchorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociNetworkAnchorUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciNetworkAnchorUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociResourceAnchorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciResourceAnchorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociVcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciVcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociVcnUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciVcnUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peeredCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PeeredCidrs
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "percentProgress", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentProgress
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap TagsAll
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkTimeoutsOutputReference\"}")]
        public virtual aws.OdbNetwork.OdbNetworkTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.OdbNetwork.OdbNetworkTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupSubnetCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupSubnetCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientSubnetCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientSubnetCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossRegionS3RestoreSourcesAccessInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CrossRegionS3RestoreSourcesAccessInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customDomainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomDomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultDnsPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultDnsPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAssociatedResourcesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteAssociatedResourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsAccessInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsAccessInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsPolicyDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsPolicyDocumentInput
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
        [JsiiProperty(name: "s3AccessInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3AccessInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3PolicyDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3PolicyDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stsAccessInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StsAccessInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stsPolicyDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StsPolicyDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.odbNetwork.OdbNetworkTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zeroEtlAccessInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZeroEtlAccessInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "crossRegionS3RestoreSourcesAccess", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CrossRegionS3RestoreSourcesAccess
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultDnsPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultDnsPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteAssociatedResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeleteAssociatedResources
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsAccess
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsPolicyDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsPolicyDocument
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

        [JsiiProperty(name: "s3Access", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Access
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3PolicyDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3PolicyDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stsAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StsAccess
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stsPolicyDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StsPolicyDocument
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

        [JsiiProperty(name: "zeroEtlAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZeroEtlAccess
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
