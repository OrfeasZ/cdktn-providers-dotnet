using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsS3BucketNotification
{
    [JsiiClass(nativeType: typeof(aws.DataAwsS3BucketNotification.DataAwsS3BucketNotificationLambdaFunctionOutputReference), fullyQualifiedName: "aws.dataAwsS3BucketNotification.DataAwsS3BucketNotificationLambdaFunctionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsS3BucketNotificationLambdaFunctionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsS3BucketNotificationLambdaFunctionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsS3BucketNotificationLambdaFunctionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsS3BucketNotificationLambdaFunctionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Events
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "filterPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FilterPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filterSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FilterSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lambdaFunctionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LambdaFunctionArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsS3BucketNotification.DataAwsS3BucketNotificationLambdaFunction\"}", isOptional: true)]
        public virtual aws.DataAwsS3BucketNotification.IDataAwsS3BucketNotificationLambdaFunction? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsS3BucketNotification.IDataAwsS3BucketNotificationLambdaFunction?>();
            set => SetInstanceProperty(value);
        }
    }
}
