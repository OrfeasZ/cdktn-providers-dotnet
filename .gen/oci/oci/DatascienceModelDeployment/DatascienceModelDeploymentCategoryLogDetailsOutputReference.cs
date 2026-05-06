using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsOutputReference), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceModelDeploymentCategoryLogDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceModelDeploymentCategoryLogDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceModelDeploymentCategoryLogDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelDeploymentCategoryLogDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccess\"}}]")]
        public virtual void PutAccess(oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPredict", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsPredict\"}}]")]
        public virtual void PutPredict(oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsPredict @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsPredict)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccess")]
        public virtual void ResetAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPredict")]
        public virtual void ResetPredict()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccessOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccessOutputReference Access
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccessOutputReference>()!;
        }

        [JsiiProperty(name: "predict", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsPredictOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsPredictOutputReference Predict
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsPredictOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccess\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsAccess? AccessInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predictInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsPredict\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsPredict? PredictInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsPredict?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetails\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
