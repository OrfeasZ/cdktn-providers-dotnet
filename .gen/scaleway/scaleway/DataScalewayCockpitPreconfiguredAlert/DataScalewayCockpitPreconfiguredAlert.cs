using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayCockpitPreconfiguredAlert
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/cockpit_preconfigured_alert scaleway_cockpit_preconfigured_alert}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlert), fullyQualifiedName: "scaleway.dataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlert", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlertConfig\"}}]")]
    public class DataScalewayCockpitPreconfiguredAlert : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/cockpit_preconfigured_alert scaleway_cockpit_preconfigured_alert} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayCockpitPreconfiguredAlert(Constructs.Construct scope, string id, scaleway.DataScalewayCockpitPreconfiguredAlert.IDataScalewayCockpitPreconfiguredAlertConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayCockpitPreconfiguredAlert.IDataScalewayCockpitPreconfiguredAlertConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayCockpitPreconfiguredAlert(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayCockpitPreconfiguredAlert(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayCockpitPreconfiguredAlert resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayCockpitPreconfiguredAlert to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayCockpitPreconfiguredAlert that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayCockpitPreconfiguredAlert to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayCockpitPreconfiguredAlert to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/cockpit_preconfigured_alert#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayCockpitPreconfiguredAlert that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayCockpitPreconfiguredAlert to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlert), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetDataSourceId")]
        public virtual void ResetDataSourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuleStatus")]
        public virtual void ResetRuleStatus()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlert))!;

        [JsiiProperty(name: "alerts", typeJson: "{\"fqn\":\"scaleway.dataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlertAlertsList\"}")]
        public virtual scaleway.DataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlertAlertsList Alerts
        {
            get => GetInstanceProperty<scaleway.DataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlertAlertsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceIdInput
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
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
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
        [JsiiProperty(name: "ruleStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceId
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
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

        [JsiiProperty(name: "ruleStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
