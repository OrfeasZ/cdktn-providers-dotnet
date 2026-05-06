using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpEsxiHost
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_esxi_host oci_ocvp_esxi_host}.</summary>
    [JsiiClass(nativeType: typeof(oci.OcvpEsxiHost.OcvpEsxiHost), fullyQualifiedName: "oci.ocvpEsxiHost.OcvpEsxiHost", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"oci.ocvpEsxiHost.OcvpEsxiHostConfig\"}}]")]
    public class OcvpEsxiHost : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_esxi_host oci_ocvp_esxi_host} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OcvpEsxiHost(Constructs.Construct scope, string id, oci.OcvpEsxiHost.IOcvpEsxiHostConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OcvpEsxiHost.IOcvpEsxiHostConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OcvpEsxiHost(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OcvpEsxiHost(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OcvpEsxiHost resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OcvpEsxiHost to import.</param>
        /// <param name="importFromId">The id of the existing OcvpEsxiHost that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OcvpEsxiHost to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OcvpEsxiHost to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_esxi_host#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OcvpEsxiHost that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OcvpEsxiHost to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OcvpEsxiHost.OcvpEsxiHost), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.ocvpEsxiHost.OcvpEsxiHostTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OcvpEsxiHost.IOcvpEsxiHostTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OcvpEsxiHost.IOcvpEsxiHostTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttachDatastoreClusterIds")]
        public virtual void ResetAttachDatastoreClusterIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBillingDonorHostId")]
        public virtual void ResetBillingDonorHostId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationId")]
        public virtual void ResetCapacityReservationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterId")]
        public virtual void ResetClusterId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeAvailabilityDomain")]
        public virtual void ResetComputeAvailabilityDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrentSku")]
        public virtual void ResetCurrentSku()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDetachDatastoreClusterIds")]
        public virtual void ResetDetachDatastoreClusterIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEsxiSoftwareVersion")]
        public virtual void ResetEsxiSoftwareVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailedEsxiHostId")]
        public virtual void ResetFailedEsxiHostId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostOcpuCount")]
        public virtual void ResetHostOcpuCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostShapeName")]
        public virtual void ResetHostShapeName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNextSku")]
        public virtual void ResetNextSku()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNonUpgradedEsxiHostId")]
        public virtual void ResetNonUpgradedEsxiHostId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSddcId")]
        public virtual void ResetSddcId()
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
        = GetStaticProperty<string>(typeof(oci.OcvpEsxiHost.OcvpEsxiHost))!;

        [JsiiProperty(name: "billingContractEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingContractEndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentCommitment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentCommitment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datastoreAttachments", typeJson: "{\"fqn\":\"oci.ocvpEsxiHost.OcvpEsxiHostDatastoreAttachmentsList\"}")]
        public virtual oci.OcvpEsxiHost.OcvpEsxiHostDatastoreAttachmentsList DatastoreAttachments
        {
            get => GetInstanceProperty<oci.OcvpEsxiHost.OcvpEsxiHostDatastoreAttachmentsList>()!;
        }

        [JsiiProperty(name: "datastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "gracePeriodEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GracePeriodEndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isBillingContinuationInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBillingContinuationInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isBillingSwappingInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBillingSwappingInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "nextCommitment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextCommitment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replacementEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplacementEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "swapBillingHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SwapBillingHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.ocvpEsxiHost.OcvpEsxiHostTimeoutsOutputReference\"}")]
        public virtual oci.OcvpEsxiHost.OcvpEsxiHostTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OcvpEsxiHost.OcvpEsxiHostTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradedReplacementEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradedReplacementEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmwareSoftwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmwareSoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attachDatastoreClusterIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AttachDatastoreClusterIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingDonorHostIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingDonorHostIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeAvailabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeAvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currentSkuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrentSkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detachDatastoreClusterIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DetachDatastoreClusterIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "esxiSoftwareVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EsxiSoftwareVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failedEsxiHostIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FailedEsxiHostIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostOcpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HostOcpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostShapeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostShapeNameInput
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
        [JsiiProperty(name: "nextSkuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NextSkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nonUpgradedEsxiHostIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NonUpgradedEsxiHostIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sddcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SddcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.ocvpEsxiHost.OcvpEsxiHostTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "attachDatastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttachDatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "billingDonorHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingDonorHostId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeAvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currentSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentSku
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "detachDatastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DetachDatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "esxiSoftwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EsxiSoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failedEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailedEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostShapeName
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

        [JsiiProperty(name: "nextSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextSku
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nonUpgradedEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NonUpgradedEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sddcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SddcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
