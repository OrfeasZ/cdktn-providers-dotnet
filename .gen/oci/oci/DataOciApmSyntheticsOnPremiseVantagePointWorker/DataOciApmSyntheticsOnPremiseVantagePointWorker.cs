using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmSyntheticsOnPremiseVantagePointWorker
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_synthetics_on_premise_vantage_point_worker oci_apm_synthetics_on_premise_vantage_point_worker}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorker), fullyQualifiedName: "oci.dataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorker", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerConfig\"}}]")]
    public class DataOciApmSyntheticsOnPremiseVantagePointWorker : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_synthetics_on_premise_vantage_point_worker oci_apm_synthetics_on_premise_vantage_point_worker} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciApmSyntheticsOnPremiseVantagePointWorker(Constructs.Construct scope, string id, oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.IDataOciApmSyntheticsOnPremiseVantagePointWorkerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.IDataOciApmSyntheticsOnPremiseVantagePointWorkerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsOnPremiseVantagePointWorker(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsOnPremiseVantagePointWorker(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciApmSyntheticsOnPremiseVantagePointWorker resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciApmSyntheticsOnPremiseVantagePointWorker to import.</param>
        /// <param name="importFromId">The id of the existing DataOciApmSyntheticsOnPremiseVantagePointWorker that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciApmSyntheticsOnPremiseVantagePointWorker to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciApmSyntheticsOnPremiseVantagePointWorker to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_synthetics_on_premise_vantage_point_worker#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciApmSyntheticsOnPremiseVantagePointWorker that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciApmSyntheticsOnPremiseVantagePointWorker to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorker), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorker))!;

        [JsiiProperty(name: "configurationDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "geoInfo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeoInfo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityInfo", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerIdentityInfoList\"}")]
        public virtual oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerIdentityInfoList IdentityInfo
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerIdentityInfoList>()!;
        }

        [JsiiProperty(name: "monitorList", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerMonitorListStructList\"}")]
        public virtual oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerMonitorListStructList MonitorList
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerMonitorListStructList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opvpId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpvpId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opvpName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpvpName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "resourcePrincipalTokenPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourcePrincipalTokenPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runtimeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastSyncUp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastSyncUp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerVersionDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerVersionDetailsList VersionDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsOnPremiseVantagePointWorker.DataOciApmSyntheticsOnPremiseVantagePointWorkerVersionDetailsList>()!;
        }

        [JsiiProperty(name: "workerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apmDomainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApmDomainIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onPremiseVantagePointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnPremiseVantagePointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onPremiseVantagePointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnPremiseVantagePointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
