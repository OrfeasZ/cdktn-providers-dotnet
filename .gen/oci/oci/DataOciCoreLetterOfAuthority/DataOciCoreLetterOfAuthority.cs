using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreLetterOfAuthority
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_letter_of_authority oci_core_letter_of_authority}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCoreLetterOfAuthority.DataOciCoreLetterOfAuthority), fullyQualifiedName: "oci.dataOciCoreLetterOfAuthority.DataOciCoreLetterOfAuthority", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCoreLetterOfAuthority.DataOciCoreLetterOfAuthorityConfig\"}}]")]
    public class DataOciCoreLetterOfAuthority : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_letter_of_authority oci_core_letter_of_authority} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCoreLetterOfAuthority(Constructs.Construct scope, string id, oci.DataOciCoreLetterOfAuthority.IDataOciCoreLetterOfAuthorityConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCoreLetterOfAuthority.IDataOciCoreLetterOfAuthorityConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreLetterOfAuthority(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreLetterOfAuthority(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCoreLetterOfAuthority resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCoreLetterOfAuthority to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCoreLetterOfAuthority that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCoreLetterOfAuthority to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCoreLetterOfAuthority to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/core_letter_of_authority#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCoreLetterOfAuthority that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCoreLetterOfAuthority to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCoreLetterOfAuthority.DataOciCoreLetterOfAuthority), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCoreLetterOfAuthority.DataOciCoreLetterOfAuthority))!;

        [JsiiProperty(name: "authorizedEntityName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizedEntityName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "circuitType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CircuitType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "facilityLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FacilityLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeIssued", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeIssued
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossConnectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CrossConnectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "crossConnectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrossConnectId
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
