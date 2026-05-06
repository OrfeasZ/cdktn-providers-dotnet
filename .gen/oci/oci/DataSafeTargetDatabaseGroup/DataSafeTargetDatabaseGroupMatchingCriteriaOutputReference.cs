using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabaseGroup
{
    [JsiiClass(nativeType: typeof(oci.DataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaOutputReference), fullyQualifiedName: "oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataSafeTargetDatabaseGroupMatchingCriteriaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataSafeTargetDatabaseGroupMatchingCriteriaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataSafeTargetDatabaseGroupMatchingCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeTargetDatabaseGroupMatchingCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExclude\"}}]")]
        public virtual void PutExclude(oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaExclude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaExclude)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaInclude\"}}]")]
        public virtual void PutInclude(oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaInclude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaInclude)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExclude")]
        public virtual void ResetExclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExcludeOutputReference\"}")]
        public virtual oci.DataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExcludeOutputReference Exclude
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExcludeOutputReference>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaIncludeOutputReference\"}")]
        public virtual oci.DataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaIncludeOutputReference Include
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaIncludeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeInput", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExclude\"}", isOptional: true)]
        public virtual oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaExclude? ExcludeInput
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaExclude?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeInput", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaInclude\"}", isOptional: true)]
        public virtual oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaInclude? IncludeInput
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaInclude?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteria\"}", isOptional: true)]
        public virtual oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteria? InternalValue
        {
            get => GetInstanceProperty<oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
