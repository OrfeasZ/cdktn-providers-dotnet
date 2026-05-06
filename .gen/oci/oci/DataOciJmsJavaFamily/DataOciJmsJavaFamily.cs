using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaFamily
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_family oci_jms_java_family}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciJmsJavaFamily.DataOciJmsJavaFamily), fullyQualifiedName: "oci.dataOciJmsJavaFamily.DataOciJmsJavaFamily", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciJmsJavaFamily.DataOciJmsJavaFamilyConfig\"}}]")]
    public class DataOciJmsJavaFamily : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_family oci_jms_java_family} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciJmsJavaFamily(Constructs.Construct scope, string id, oci.DataOciJmsJavaFamily.IDataOciJmsJavaFamilyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciJmsJavaFamily.IDataOciJmsJavaFamilyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaFamily(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaFamily(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciJmsJavaFamily resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciJmsJavaFamily to import.</param>
        /// <param name="importFromId">The id of the existing DataOciJmsJavaFamily that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciJmsJavaFamily to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciJmsJavaFamily to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_family#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciJmsJavaFamily that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciJmsJavaFamily to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciJmsJavaFamily.DataOciJmsJavaFamily), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciJmsJavaFamily.DataOciJmsJavaFamily))!;

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "docUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endOfSupportLifeDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndOfSupportLifeDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isSupportedVersion", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSupportedVersion
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "latestReleaseArtifacts", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaFamily.DataOciJmsJavaFamilyLatestReleaseArtifactsList\"}")]
        public virtual oci.DataOciJmsJavaFamily.DataOciJmsJavaFamilyLatestReleaseArtifactsList LatestReleaseArtifacts
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaFamily.DataOciJmsJavaFamilyLatestReleaseArtifactsList>()!;
        }

        [JsiiProperty(name: "latestReleaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestReleaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LicenseTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "releaseDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "familyVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FamilyVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "familyVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FamilyVersion
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
