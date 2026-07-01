using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsS3BucketNotification
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/data-sources/s3_bucket_notification aws_s3_bucket_notification}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsS3BucketNotification.DataAwsS3BucketNotification), fullyQualifiedName: "aws.dataAwsS3BucketNotification.DataAwsS3BucketNotification", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsS3BucketNotification.DataAwsS3BucketNotificationConfig\"}}]")]
    public class DataAwsS3BucketNotification : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/data-sources/s3_bucket_notification aws_s3_bucket_notification} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsS3BucketNotification(Constructs.Construct scope, string id, aws.DataAwsS3BucketNotification.IDataAwsS3BucketNotificationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsS3BucketNotification.IDataAwsS3BucketNotificationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsS3BucketNotification(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsS3BucketNotification(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsS3BucketNotification resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsS3BucketNotification to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsS3BucketNotification that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsS3BucketNotification to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsS3BucketNotification to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/data-sources/s3_bucket_notification#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsS3BucketNotification that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsS3BucketNotification to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsS3BucketNotification.DataAwsS3BucketNotification), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsS3BucketNotification.DataAwsS3BucketNotification))!;

        [JsiiProperty(name: "eventbridge", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Eventbridge
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lambdaFunction", typeJson: "{\"fqn\":\"aws.dataAwsS3BucketNotification.DataAwsS3BucketNotificationLambdaFunctionList\"}")]
        public virtual aws.DataAwsS3BucketNotification.DataAwsS3BucketNotificationLambdaFunctionList LambdaFunction
        {
            get => GetInstanceProperty<aws.DataAwsS3BucketNotification.DataAwsS3BucketNotificationLambdaFunctionList>()!;
        }

        [JsiiProperty(name: "queue", typeJson: "{\"fqn\":\"aws.dataAwsS3BucketNotification.DataAwsS3BucketNotificationQueueList\"}")]
        public virtual aws.DataAwsS3BucketNotification.DataAwsS3BucketNotificationQueueList Queue
        {
            get => GetInstanceProperty<aws.DataAwsS3BucketNotification.DataAwsS3BucketNotificationQueueList>()!;
        }

        [JsiiProperty(name: "topic", typeJson: "{\"fqn\":\"aws.dataAwsS3BucketNotification.DataAwsS3BucketNotificationTopicList\"}")]
        public virtual aws.DataAwsS3BucketNotification.DataAwsS3BucketNotificationTopicList Topic
        {
            get => GetInstanceProperty<aws.DataAwsS3BucketNotification.DataAwsS3BucketNotificationTopicList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
