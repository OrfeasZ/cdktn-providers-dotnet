using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiClass(nativeType: typeof(aws.OpensearchDomain.OpensearchDomainAimlOptionsOutputReference), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAimlOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchDomainAimlOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchDomainAimlOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchDomainAimlOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDomainAimlOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNaturalLanguageQueryGenerationOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions\"}}]")]
        public virtual void PutNaturalLanguageQueryGenerationOptions(aws.OpensearchDomain.IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3VectorsEngine", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsS3VectorsEngine\"}}]")]
        public virtual void PutS3VectorsEngine(aws.OpensearchDomain.IOpensearchDomainAimlOptionsS3VectorsEngine @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainAimlOptionsS3VectorsEngine)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerlessVectorAcceleration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsServerlessVectorAcceleration\"}}]")]
        public virtual void PutServerlessVectorAcceleration(aws.OpensearchDomain.IOpensearchDomainAimlOptionsServerlessVectorAcceleration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainAimlOptionsServerlessVectorAcceleration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetNaturalLanguageQueryGenerationOptions")]
        public virtual void ResetNaturalLanguageQueryGenerationOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3VectorsEngine")]
        public virtual void ResetS3VectorsEngine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerlessVectorAcceleration")]
        public virtual void ResetServerlessVectorAcceleration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "naturalLanguageQueryGenerationOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptionsOutputReference NaturalLanguageQueryGenerationOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "s3VectorsEngine", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsS3VectorsEngineOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainAimlOptionsS3VectorsEngineOutputReference S3VectorsEngine
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainAimlOptionsS3VectorsEngineOutputReference>()!;
        }

        [JsiiProperty(name: "serverlessVectorAcceleration", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsServerlessVectorAccelerationOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainAimlOptionsServerlessVectorAccelerationOutputReference ServerlessVectorAcceleration
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainAimlOptionsServerlessVectorAccelerationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "naturalLanguageQueryGenerationOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions? NaturalLanguageQueryGenerationOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3VectorsEngineInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsS3VectorsEngine\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainAimlOptionsS3VectorsEngine? S3VectorsEngineInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAimlOptionsS3VectorsEngine?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverlessVectorAccelerationInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsServerlessVectorAcceleration\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainAimlOptionsServerlessVectorAcceleration? ServerlessVectorAccelerationInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAimlOptionsServerlessVectorAcceleration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainAimlOptions? InternalValue
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAimlOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
