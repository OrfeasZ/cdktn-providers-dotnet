using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreCrossConnect
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_cross_connect oci_core_cross_connect}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCoreCrossConnect.DataOciCoreCrossConnect), fullyQualifiedName: "oci.dataOciCoreCrossConnect.DataOciCoreCrossConnect", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCoreCrossConnect.DataOciCoreCrossConnectConfig\"}}]")]
    public class DataOciCoreCrossConnect : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_cross_connect oci_core_cross_connect} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCoreCrossConnect(Constructs.Construct scope, string id, oci.DataOciCoreCrossConnect.IDataOciCoreCrossConnectConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCoreCrossConnect.IDataOciCoreCrossConnectConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreCrossConnect(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreCrossConnect(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCoreCrossConnect resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCoreCrossConnect to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCoreCrossConnect that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCoreCrossConnect to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCoreCrossConnect to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_cross_connect#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCoreCrossConnect that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCoreCrossConnect to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCoreCrossConnect.DataOciCoreCrossConnect), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCoreCrossConnect.DataOciCoreCrossConnect))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crossConnectGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrossConnectGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerReferenceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerReferenceName
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

        [JsiiProperty(name: "farCrossConnectOrCrossConnectGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FarCrossConnectOrCrossConnectGroupId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "isActive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsActive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "locationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "macsecProperties", typeJson: "{\"fqn\":\"oci.dataOciCoreCrossConnect.DataOciCoreCrossConnectMacsecPropertiesList\"}")]
        public virtual oci.DataOciCoreCrossConnect.DataOciCoreCrossConnectMacsecPropertiesList MacsecProperties
        {
            get => GetInstanceProperty<oci.DataOciCoreCrossConnect.DataOciCoreCrossConnectMacsecPropertiesList>()!;
        }

        [JsiiProperty(name: "nearCrossConnectOrCrossConnectGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NearCrossConnectOrCrossConnectGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociLogicalDeviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciLogicalDeviceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociPhysicalDeviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciPhysicalDeviceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portSpeedShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortSpeedShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossConnectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CrossConnectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "crossConnectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrossConnectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
