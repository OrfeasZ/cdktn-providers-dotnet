using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiClass(nativeType: typeof(aws.DynamodbTable.DynamodbTableWarmThroughputOutputReference), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableWarmThroughputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DynamodbTableWarmThroughputOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DynamodbTableWarmThroughputOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTableWarmThroughputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTableWarmThroughputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetReadUnitsPerSecond")]
        public virtual void ResetReadUnitsPerSecond()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteUnitsPerSecond")]
        public virtual void ResetWriteUnitsPerSecond()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "readUnitsPerSecondInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadUnitsPerSecondInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeUnitsPerSecondInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteUnitsPerSecondInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "readUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadUnitsPerSecond
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeUnitsPerSecond", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteUnitsPerSecond
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableWarmThroughput\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableWarmThroughput? InternalValue
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableWarmThroughput?>();
            set => SetInstanceProperty(value);
        }
    }
}
