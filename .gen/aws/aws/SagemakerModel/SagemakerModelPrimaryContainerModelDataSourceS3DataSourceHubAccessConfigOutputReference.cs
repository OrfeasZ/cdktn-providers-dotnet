using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiClass(nativeType: typeof(aws.SagemakerModel.SagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfigOutputReference), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "hubContentArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HubContentArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hubContentArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HubContentArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSourceS3DataSourceHubAccessConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
