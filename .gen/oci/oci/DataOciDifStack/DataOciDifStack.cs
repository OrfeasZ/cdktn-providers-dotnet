using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDifStack
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/dif_stack oci_dif_stack}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDifStack.DataOciDifStack), fullyQualifiedName: "oci.dataOciDifStack.DataOciDifStack", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackConfig\"}}]")]
    public class DataOciDifStack : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/dif_stack oci_dif_stack} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDifStack(Constructs.Construct scope, string id, oci.DataOciDifStack.IDataOciDifStackConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDifStack.IDataOciDifStackConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDifStack(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDifStack(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDifStack resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDifStack to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDifStack that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDifStack to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDifStack to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/data-sources/dif_stack#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDifStack that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDifStack to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDifStack.DataOciDifStack), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDifStack.DataOciDifStack))!;

        [JsiiProperty(name: "adb", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackAdbList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackAdbList Adb
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackAdbList>()!;
        }

        [JsiiProperty(name: "addServiceTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AddServiceTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "aidataplatform", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackAidataplatformList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackAidataplatformList Aidataplatform
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackAidataplatformList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataflow", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackDataflowList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackDataflowList Dataflow
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackDataflowList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deployArtifactsTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeployArtifactsTrigger
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "genai", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackGenaiList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackGenaiList Genai
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackGenaiList>()!;
        }

        [JsiiProperty(name: "ggcs", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackGgcsList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackGgcsList Ggcs
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackGgcsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectstorage", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackObjectstorageList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackObjectstorageList Objectstorage
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackObjectstorageList>()!;
        }

        [JsiiProperty(name: "oke", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackOkeList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackOkeList Oke
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackOkeList>()!;
        }

        [JsiiProperty(name: "omk", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackOmkList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackOmkList Omk
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackOmkList>()!;
        }

        [JsiiProperty(name: "serviceDetails", typeJson: "{\"fqn\":\"oci.dataOciDifStack.DataOciDifStackServiceDetailsList\"}")]
        public virtual oci.DataOciDifStack.DataOciDifStackServiceDetailsList ServiceDetails
        {
            get => GetInstanceProperty<oci.DataOciDifStack.DataOciDifStackServiceDetailsList>()!;
        }

        [JsiiProperty(name: "services", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Services
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "stackTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StackTemplates
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stackIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StackIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
