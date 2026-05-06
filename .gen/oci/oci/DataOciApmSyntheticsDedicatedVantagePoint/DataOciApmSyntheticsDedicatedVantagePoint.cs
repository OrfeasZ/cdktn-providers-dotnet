using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmSyntheticsDedicatedVantagePoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_synthetics_dedicated_vantage_point oci_apm_synthetics_dedicated_vantage_point}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePoint), fullyQualifiedName: "oci.dataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePointConfig\"}}]")]
    public class DataOciApmSyntheticsDedicatedVantagePoint : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_synthetics_dedicated_vantage_point oci_apm_synthetics_dedicated_vantage_point} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciApmSyntheticsDedicatedVantagePoint(Constructs.Construct scope, string id, oci.DataOciApmSyntheticsDedicatedVantagePoint.IDataOciApmSyntheticsDedicatedVantagePointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciApmSyntheticsDedicatedVantagePoint.IDataOciApmSyntheticsDedicatedVantagePointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsDedicatedVantagePoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsDedicatedVantagePoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciApmSyntheticsDedicatedVantagePoint resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciApmSyntheticsDedicatedVantagePoint to import.</param>
        /// <param name="importFromId">The id of the existing DataOciApmSyntheticsDedicatedVantagePoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciApmSyntheticsDedicatedVantagePoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciApmSyntheticsDedicatedVantagePoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/apm_synthetics_dedicated_vantage_point#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciApmSyntheticsDedicatedVantagePoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciApmSyntheticsDedicatedVantagePoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePoint))!;

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

        [JsiiProperty(name: "dvpStackDetails", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePointDvpStackDetailsList\"}")]
        public virtual oci.DataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePointDvpStackDetailsList DvpStackDetails
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePointDvpStackDetailsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monitorStatusCountMap", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePointMonitorStatusCountMapList\"}")]
        public virtual oci.DataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePointMonitorStatusCountMapList MonitorStatusCountMap
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsDedicatedVantagePoint.DataOciApmSyntheticsDedicatedVantagePointMonitorStatusCountMapList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
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
        [JsiiProperty(name: "dedicatedVantagePointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DedicatedVantagePointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dedicatedVantagePointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedVantagePointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
