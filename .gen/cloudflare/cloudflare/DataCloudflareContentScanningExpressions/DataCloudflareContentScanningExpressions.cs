using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareContentScanningExpressions
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/content_scanning_expressions cloudflare_content_scanning_expressions}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareContentScanningExpressions.DataCloudflareContentScanningExpressions), fullyQualifiedName: "cloudflare.dataCloudflareContentScanningExpressions.DataCloudflareContentScanningExpressions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareContentScanningExpressions.DataCloudflareContentScanningExpressionsConfig\"}}]")]
    public class DataCloudflareContentScanningExpressions : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/content_scanning_expressions cloudflare_content_scanning_expressions} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareContentScanningExpressions(Constructs.Construct scope, string id, cloudflare.DataCloudflareContentScanningExpressions.IDataCloudflareContentScanningExpressionsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareContentScanningExpressions.IDataCloudflareContentScanningExpressionsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareContentScanningExpressions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareContentScanningExpressions(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareContentScanningExpressions resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareContentScanningExpressions to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareContentScanningExpressions that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareContentScanningExpressions to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareContentScanningExpressions to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/content_scanning_expressions#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareContentScanningExpressions that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareContentScanningExpressions to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareContentScanningExpressions.DataCloudflareContentScanningExpressions), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetMaxItems")]
        public virtual void ResetMaxItems()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareContentScanningExpressions.DataCloudflareContentScanningExpressions))!;

        [JsiiProperty(name: "result", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareContentScanningExpressions.DataCloudflareContentScanningExpressionsResultList\"}")]
        public virtual cloudflare.DataCloudflareContentScanningExpressions.DataCloudflareContentScanningExpressionsResultList Result
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareContentScanningExpressions.DataCloudflareContentScanningExpressionsResultList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxItemsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxItemsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxItems
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
