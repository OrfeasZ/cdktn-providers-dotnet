using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsJavaDownloadsJavaDownloadToken
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_downloads_java_download_token oci_jms_java_downloads_java_download_token}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadToken), fullyQualifiedName: "oci.dataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadToken", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadTokenConfig\"}}]")]
    public class DataOciJmsJavaDownloadsJavaDownloadToken : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_downloads_java_download_token oci_jms_java_downloads_java_download_token} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciJmsJavaDownloadsJavaDownloadToken(Constructs.Construct scope, string id, oci.DataOciJmsJavaDownloadsJavaDownloadToken.IDataOciJmsJavaDownloadsJavaDownloadTokenConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciJmsJavaDownloadsJavaDownloadToken.IDataOciJmsJavaDownloadsJavaDownloadTokenConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaDownloadsJavaDownloadToken(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsJavaDownloadsJavaDownloadToken(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciJmsJavaDownloadsJavaDownloadToken resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciJmsJavaDownloadsJavaDownloadToken to import.</param>
        /// <param name="importFromId">The id of the existing DataOciJmsJavaDownloadsJavaDownloadToken that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciJmsJavaDownloadsJavaDownloadToken to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciJmsJavaDownloadsJavaDownloadToken to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_java_downloads_java_download_token#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciJmsJavaDownloadsJavaDownloadToken that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciJmsJavaDownloadsJavaDownloadToken to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadToken), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadToken))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadTokenCreatedByList\"}")]
        public virtual oci.DataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadTokenCreatedByList CreatedBy
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadTokenCreatedByList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "isDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUpdatedBy", typeJson: "{\"fqn\":\"oci.dataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadTokenLastUpdatedByList\"}")]
        public virtual oci.DataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadTokenLastUpdatedByList LastUpdatedBy
        {
            get => GetInstanceProperty<oci.DataOciJmsJavaDownloadsJavaDownloadToken.DataOciJmsJavaDownloadsJavaDownloadTokenLastUpdatedByList>()!;
        }

        [JsiiProperty(name: "licenseType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LicenseType
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastUsed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastUsed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "javaDownloadTokenIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JavaDownloadTokenIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "javaDownloadTokenId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaDownloadTokenId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
