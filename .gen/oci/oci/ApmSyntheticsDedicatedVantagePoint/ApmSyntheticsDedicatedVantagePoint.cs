using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsDedicatedVantagePoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point oci_apm_synthetics_dedicated_vantage_point}.</summary>
    [JsiiClass(nativeType: typeof(oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePoint), fullyQualifiedName: "oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointConfig\"}}]")]
    public class ApmSyntheticsDedicatedVantagePoint : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point oci_apm_synthetics_dedicated_vantage_point} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApmSyntheticsDedicatedVantagePoint(Constructs.Construct scope, string id, oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsDedicatedVantagePoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsDedicatedVantagePoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ApmSyntheticsDedicatedVantagePoint resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApmSyntheticsDedicatedVantagePoint to import.</param>
        /// <param name="importFromId">The id of the existing ApmSyntheticsDedicatedVantagePoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApmSyntheticsDedicatedVantagePoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApmSyntheticsDedicatedVantagePoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApmSyntheticsDedicatedVantagePoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApmSyntheticsDedicatedVantagePoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDvpStackDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetails\"}}]")]
        public virtual void PutDvpStackDetails(oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointDvpStackDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointDvpStackDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
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
        = GetStaticProperty<string>(typeof(oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePoint))!;

        [JsiiProperty(name: "dvpStackDetails", typeJson: "{\"fqn\":\"oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetailsOutputReference\"}")]
        public virtual oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetailsOutputReference DvpStackDetails
        {
            get => GetInstanceProperty<oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "monitorStatusCountMap", typeJson: "{\"fqn\":\"oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointMonitorStatusCountMapList\"}")]
        public virtual oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointMonitorStatusCountMapList MonitorStatusCountMap
        {
            get => GetInstanceProperty<oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointMonitorStatusCountMapList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointTimeoutsOutputReference\"}")]
        public virtual oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ApmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dvpStackDetailsInput", typeJson: "{\"fqn\":\"oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetails\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointDvpStackDetails? DvpStackDetailsInput
        {
            get => GetInstanceProperty<oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointDvpStackDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
