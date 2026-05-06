using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabasesDatabaseParameter
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabasesDatabaseParameter.DataOciDatabaseManagementManagedDatabasesDatabaseParameterItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabasesDatabaseParameter.DataOciDatabaseManagementManagedDatabasesDatabaseParameterItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedDatabasesDatabaseParameterItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedDatabasesDatabaseParameterItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedDatabasesDatabaseParameterItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabasesDatabaseParameterItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedValues", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabasesDatabaseParameter.DataOciDatabaseManagementManagedDatabasesDatabaseParameterItemsAllowedValuesList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabasesDatabaseParameter.DataOciDatabaseManagementManagedDatabasesDatabaseParameterItemsAllowedValuesList AllowedValues
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabasesDatabaseParameter.DataOciDatabaseManagementManagedDatabasesDatabaseParameterItemsAllowedValuesList>()!;
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "constraint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Constraint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContainerId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAdjusted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAdjusted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isBasic", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBasic
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDeprecated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDeprecated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isInstanceModifiable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsInstanceModifiable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IsModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isPdbModifiable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPdbModifiable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSessionModifiable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSessionModifiable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSpecified", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSpecified
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSystemModifiable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IsSystemModifiable
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Number
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ordinal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ordinal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateComment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateComment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabasesDatabaseParameter.DataOciDatabaseManagementManagedDatabasesDatabaseParameterItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedDatabasesDatabaseParameter.IDataOciDatabaseManagementManagedDatabasesDatabaseParameterItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabasesDatabaseParameter.IDataOciDatabaseManagementManagedDatabasesDatabaseParameterItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
