using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiClass(nativeType: typeof(aws.GlueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecOutputReference), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFields(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSpecId")]
        public virtual void ResetSpecId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fields", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFieldsList\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFieldsList Fields
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFieldsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "specIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SpecIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "specId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpecId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec? InternalValue
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
