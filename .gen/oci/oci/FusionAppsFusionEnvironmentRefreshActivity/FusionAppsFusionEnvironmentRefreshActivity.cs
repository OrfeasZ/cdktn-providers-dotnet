using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentRefreshActivity
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_refresh_activity oci_fusion_apps_fusion_environment_refresh_activity}.</summary>
    [JsiiClass(nativeType: typeof(oci.FusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivity), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivity", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.fusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityConfig\"}}]")]
    public class FusionAppsFusionEnvironmentRefreshActivity : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_refresh_activity oci_fusion_apps_fusion_environment_refresh_activity} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FusionAppsFusionEnvironmentRefreshActivity(Constructs.Construct scope, string id, oci.FusionAppsFusionEnvironmentRefreshActivity.IFusionAppsFusionEnvironmentRefreshActivityConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.FusionAppsFusionEnvironmentRefreshActivity.IFusionAppsFusionEnvironmentRefreshActivityConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FusionAppsFusionEnvironmentRefreshActivity(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FusionAppsFusionEnvironmentRefreshActivity(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FusionAppsFusionEnvironmentRefreshActivity resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FusionAppsFusionEnvironmentRefreshActivity to import.</param>
        /// <param name="importFromId">The id of the existing FusionAppsFusionEnvironmentRefreshActivity that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FusionAppsFusionEnvironmentRefreshActivity to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FusionAppsFusionEnvironmentRefreshActivity to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_refresh_activity#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FusionAppsFusionEnvironmentRefreshActivity that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FusionAppsFusionEnvironmentRefreshActivity to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.FusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivity), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.FusionAppsFusionEnvironmentRefreshActivity.IFusionAppsFusionEnvironmentRefreshActivityTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FusionAppsFusionEnvironmentRefreshActivity.IFusionAppsFusionEnvironmentRefreshActivityTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsDataMaskingOpted")]
        public virtual void ResetIsDataMaskingOpted()
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
        = GetStaticProperty<string>(typeof(oci.FusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivity))!;

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshActivityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshActivityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshIssueDetailsList", typeJson: "{\"fqn\":\"oci.fusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityRefreshIssueDetailsListStructList\"}")]
        public virtual oci.FusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityRefreshIssueDetailsListStructList RefreshIssueDetailsList
        {
            get => GetInstanceProperty<oci.FusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityRefreshIssueDetailsListStructList>()!;
        }

        [JsiiProperty(name: "serviceAvailability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAvailability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpectedFinish", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpectedFinish
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfRestorationPoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfRestorationPoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityTimeoutsOutputReference\"}")]
        public virtual oci.FusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.FusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fusionEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FusionEnvironmentIdInput
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
        [JsiiProperty(name: "isDataMaskingOptedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsDataMaskingOptedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceFusionEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceFusionEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "fusionEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FusionEnvironmentId
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

        [JsiiProperty(name: "isDataMaskingOpted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsDataMaskingOpted
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

        [JsiiProperty(name: "sourceFusionEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceFusionEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
