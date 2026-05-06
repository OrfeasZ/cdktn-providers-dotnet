using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceImportRequest
{
    [JsiiClass(nativeType: typeof(oci.DataintegrationWorkspaceImportRequest.DataintegrationWorkspaceImportRequestImportConflictResolutionOutputReference), fullyQualifiedName: "oci.dataintegrationWorkspaceImportRequest.DataintegrationWorkspaceImportRequestImportConflictResolutionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataintegrationWorkspaceImportRequestImportConflictResolutionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataintegrationWorkspaceImportRequestImportConflictResolutionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataintegrationWorkspaceImportRequestImportConflictResolutionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataintegrationWorkspaceImportRequestImportConflictResolutionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDuplicatePrefix")]
        public virtual void ResetDuplicatePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDuplicateSuffix")]
        public virtual void ResetDuplicateSuffix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "duplicatePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DuplicatePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "duplicateSuffixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DuplicateSuffixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "importConflictResolutionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImportConflictResolutionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "duplicatePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DuplicatePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "duplicateSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DuplicateSuffix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "importConflictResolutionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImportConflictResolutionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceImportRequest.DataintegrationWorkspaceImportRequestImportConflictResolution\"}", isOptional: true)]
        public virtual oci.DataintegrationWorkspaceImportRequest.IDataintegrationWorkspaceImportRequestImportConflictResolution? InternalValue
        {
            get => GetInstanceProperty<oci.DataintegrationWorkspaceImportRequest.IDataintegrationWorkspaceImportRequestImportConflictResolution?>();
            set => SetInstanceProperty(value);
        }
    }
}
