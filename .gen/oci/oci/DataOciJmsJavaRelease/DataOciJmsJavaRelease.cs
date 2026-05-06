using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaRelease
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_release oci_jms_java_release}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciJmsJavaRelease.DataOciJmsJavaRelease), fullyQualifiedName: "oci.dataOciJmsJavaRelease.DataOciJmsJavaRelease", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciJmsJavaRelease.DataOciJmsJavaReleaseConfig\"}}]")]
    public class DataOciJmsJavaRelease : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_release oci_jms_java_release} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciJmsJavaRelease(Constructs.Construct scope, string id, oci.DataOciJmsJavaRelease.IDataOciJmsJavaReleaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciJmsJavaRelease.IDataOciJmsJavaReleaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaRelease(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaRelease(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciJmsJavaRelease resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciJmsJavaRelease to import.</param>
        /// <param name="importFromId">The id of the existing DataOciJmsJavaRelease that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciJmsJavaRelease to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciJmsJavaRelease to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_release#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciJmsJavaRelease that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciJmsJavaRelease to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciJmsJavaRelease.DataOciJmsJavaRelease), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciJmsJavaRelease.DataOciJmsJavaRelease))!;

        [JsiiProperty(name: "artifactContentTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ArtifactContentTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaRelease.DataOciJmsJavaReleaseArtifactsList\"}")]
        public virtual oci.DataOciJmsJavaRelease.DataOciJmsJavaReleaseArtifactsList Artifacts
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaRelease.DataOciJmsJavaReleaseArtifactsList>()!;
        }

        [JsiiProperty(name: "daysUnderSecurityBaseline", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysUnderSecurityBaseline
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "familyDetails", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaRelease.DataOciJmsJavaReleaseFamilyDetailsList\"}")]
        public virtual oci.DataOciJmsJavaRelease.DataOciJmsJavaReleaseFamilyDetailsList FamilyDetails
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaRelease.DataOciJmsJavaReleaseFamilyDetailsList>()!;
        }

        [JsiiProperty(name: "familyVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FamilyVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseDetails", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaRelease.DataOciJmsJavaReleaseLicenseDetailsList\"}")]
        public virtual oci.DataOciJmsJavaRelease.DataOciJmsJavaReleaseLicenseDetailsList LicenseDetails
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaRelease.DataOciJmsJavaReleaseLicenseDetailsList>()!;
        }

        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mosPatches", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaRelease.DataOciJmsJavaReleaseMosPatchesList\"}")]
        public virtual oci.DataOciJmsJavaRelease.DataOciJmsJavaReleaseMosPatchesList MosPatches
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaRelease.DataOciJmsJavaReleaseMosPatchesList>()!;
        }

        [JsiiProperty(name: "parentReleaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentReleaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseNotesUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseNotesUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
