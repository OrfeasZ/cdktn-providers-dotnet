using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig")]
    public interface ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#accept_eula SagemakerModel#accept_eula}.</summary>
        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AcceptEula
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_model#accept_eula SagemakerModel#accept_eula}.</summary>
            [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AcceptEula
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
