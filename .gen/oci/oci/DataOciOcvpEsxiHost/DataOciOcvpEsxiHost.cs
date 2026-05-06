using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOcvpEsxiHost
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ocvp_esxi_host oci_ocvp_esxi_host}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOcvpEsxiHost.DataOciOcvpEsxiHost), fullyQualifiedName: "oci.dataOciOcvpEsxiHost.DataOciOcvpEsxiHost", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOcvpEsxiHost.DataOciOcvpEsxiHostConfig\"}}]")]
    public class DataOciOcvpEsxiHost : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ocvp_esxi_host oci_ocvp_esxi_host} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOcvpEsxiHost(Constructs.Construct scope, string id, oci.DataOciOcvpEsxiHost.IDataOciOcvpEsxiHostConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOcvpEsxiHost.IDataOciOcvpEsxiHostConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpEsxiHost(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpEsxiHost(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOcvpEsxiHost resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOcvpEsxiHost to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOcvpEsxiHost that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOcvpEsxiHost to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOcvpEsxiHost to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ocvp_esxi_host#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOcvpEsxiHost that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOcvpEsxiHost to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOcvpEsxiHost.DataOciOcvpEsxiHost), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOcvpEsxiHost.DataOciOcvpEsxiHost))!;

        [JsiiProperty(name: "attachDatastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttachDatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "billingContractEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingContractEndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingDonorHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingDonorHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeAvailabilityDomain
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

        [JsiiProperty(name: "currentSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentSku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datastoreAttachments", typeJson: "{\"fqn\":\"oci.dataOciOcvpEsxiHost.DataOciOcvpEsxiHostDatastoreAttachmentsList\"}")]
        public virtual oci.DataOciOcvpEsxiHost.DataOciOcvpEsxiHostDatastoreAttachmentsList DatastoreAttachments
        {
            get => GetInstanceProperty<oci.DataOciOcvpEsxiHost.DataOciOcvpEsxiHostDatastoreAttachmentsList>()!;
        }

        [JsiiProperty(name: "datastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "detachDatastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DetachDatastoreClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "esxiSoftwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EsxiSoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failedEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailedEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gracePeriodEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GracePeriodEndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hostShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

        [JsiiProperty(name: "nextSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextSku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nonUpgradedEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NonUpgradedEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replacementEsxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplacementEsxiHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sddcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SddcId
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
        [JsiiProperty(name: "esxiHostIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EsxiHostIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "esxiHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EsxiHostId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
