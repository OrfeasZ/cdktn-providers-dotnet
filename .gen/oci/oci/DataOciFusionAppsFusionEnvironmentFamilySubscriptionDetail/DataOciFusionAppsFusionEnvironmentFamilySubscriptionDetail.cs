using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fusion_apps_fusion_environment_family_subscription_detail oci_fusion_apps_fusion_environment_family_subscription_detail}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail), fullyQualifiedName: "oci.dataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetailConfig\"}}]")]
    public class DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fusion_apps_fusion_environment_family_subscription_detail oci_fusion_apps_fusion_environment_family_subscription_detail} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail(Constructs.Construct scope, string id, oci.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.IDataOciFusionAppsFusionEnvironmentFamilySubscriptionDetailConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.IDataOciFusionAppsFusionEnvironmentFamilySubscriptionDetailConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail to import.</param>
        /// <param name="importFromId">The id of the existing DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fusion_apps_fusion_environment_family_subscription_detail#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail))!;

        [JsiiProperty(name: "subscriptions", typeJson: "{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetailSubscriptionsList\"}")]
        public virtual oci.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetailSubscriptionsList Subscriptions
        {
            get => GetInstanceProperty<oci.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetail.DataOciFusionAppsFusionEnvironmentFamilySubscriptionDetailSubscriptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fusionEnvironmentFamilyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FusionEnvironmentFamilyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fusionEnvironmentFamilyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FusionEnvironmentFamilyId
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
    }
}
