using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreFirmwareBundle
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/core_firmware_bundle oci_core_firmware_bundle}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCoreFirmwareBundle.DataOciCoreFirmwareBundle), fullyQualifiedName: "oci.dataOciCoreFirmwareBundle.DataOciCoreFirmwareBundle", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCoreFirmwareBundle.DataOciCoreFirmwareBundleConfig\"}}]")]
    public class DataOciCoreFirmwareBundle : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/core_firmware_bundle oci_core_firmware_bundle} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCoreFirmwareBundle(Constructs.Construct scope, string id, oci.DataOciCoreFirmwareBundle.IDataOciCoreFirmwareBundleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCoreFirmwareBundle.IDataOciCoreFirmwareBundleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreFirmwareBundle(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreFirmwareBundle(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCoreFirmwareBundle resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCoreFirmwareBundle to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCoreFirmwareBundle that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCoreFirmwareBundle to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCoreFirmwareBundle to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/core_firmware_bundle#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCoreFirmwareBundle that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCoreFirmwareBundle to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCoreFirmwareBundle.DataOciCoreFirmwareBundle), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCoreFirmwareBundle.DataOciCoreFirmwareBundle))!;

        [JsiiProperty(name: "allowableTransitions", typeJson: "{\"fqn\":\"oci.dataOciCoreFirmwareBundle.DataOciCoreFirmwareBundleAllowableTransitionsList\"}")]
        public virtual oci.DataOciCoreFirmwareBundle.DataOciCoreFirmwareBundleAllowableTransitionsList AllowableTransitions
        {
            get => GetInstanceProperty<oci.DataOciCoreFirmwareBundle.DataOciCoreFirmwareBundleAllowableTransitionsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platforms", typeJson: "{\"fqn\":\"oci.dataOciCoreFirmwareBundle.DataOciCoreFirmwareBundlePlatformsList\"}")]
        public virtual oci.DataOciCoreFirmwareBundle.DataOciCoreFirmwareBundlePlatformsList Platforms
        {
            get => GetInstanceProperty<oci.DataOciCoreFirmwareBundle.DataOciCoreFirmwareBundlePlatformsList>()!;
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
        [JsiiProperty(name: "firmwareBundleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirmwareBundleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "firmwareBundleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirmwareBundleId
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
