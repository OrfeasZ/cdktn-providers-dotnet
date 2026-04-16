using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    [JsiiClass(nativeType: typeof(aws.LambdaFunction.LambdaFunctionCapacityProviderConfigOutputReference), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionCapacityProviderConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaFunctionCapacityProviderConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LambdaFunctionCapacityProviderConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LambdaFunctionCapacityProviderConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionCapacityProviderConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLambdaManagedInstancesCapacityProviderConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig\"}}]")]
        public virtual void PutLambdaManagedInstancesCapacityProviderConfig(aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig)}, new object[]{@value});
        }

        [JsiiProperty(name: "lambdaManagedInstancesCapacityProviderConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfigOutputReference LambdaManagedInstancesCapacityProviderConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaManagedInstancesCapacityProviderConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig? LambdaManagedInstancesCapacityProviderConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionCapacityProviderConfigLambdaManagedInstancesCapacityProviderConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionCapacityProviderConfig? InternalValue
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionCapacityProviderConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
