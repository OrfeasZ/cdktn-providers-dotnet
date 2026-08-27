using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlBlueGreenDeployment
{
    [JsiiClass(nativeType: typeof(oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetailsOutputReference), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlBlueGreenDeploymentTargetDbSystemDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlBlueGreenDeploymentTargetDbSystemDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlBlueGreenDeploymentTargetDbSystemDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlBlueGreenDeploymentTargetDbSystemDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConfigurationId")]
        public virtual void ResetConfigurationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataStorageSizeInGb")]
        public virtual void ResetDataStorageSizeInGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShapeName")]
        public virtual void ResetShapeName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataStorageSizeInGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataStorageSizeInGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mysqlVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MysqlVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetails\"}", isOptional: true)]
        public virtual oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
