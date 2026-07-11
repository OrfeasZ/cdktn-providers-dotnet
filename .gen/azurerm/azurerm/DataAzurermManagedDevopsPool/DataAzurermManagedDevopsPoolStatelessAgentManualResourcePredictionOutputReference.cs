using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference), fullyQualifiedName: "azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allWeekSchedule", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllWeekSchedule
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fridaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionFridayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionFridayScheduleList FridaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionFridayScheduleList>()!;
        }

        [JsiiProperty(name: "mondaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionMondayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionMondayScheduleList MondaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionMondayScheduleList>()!;
        }

        [JsiiProperty(name: "saturdaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdayScheduleList SaturdaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionSaturdayScheduleList>()!;
        }

        [JsiiProperty(name: "sundaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionSundayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionSundayScheduleList SundaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionSundayScheduleList>()!;
        }

        [JsiiProperty(name: "thursdaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionThursdayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionThursdayScheduleList ThursdaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionThursdayScheduleList>()!;
        }

        [JsiiProperty(name: "timeZoneName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZoneName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tuesdaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdayScheduleList TuesdaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionTuesdayScheduleList>()!;
        }

        [JsiiProperty(name: "wednesdaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdayScheduleList WednesdaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePredictionWednesdayScheduleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatelessAgentManualResourcePrediction\"}", isOptional: true)]
        public virtual azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolStatelessAgentManualResourcePrediction? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolStatelessAgentManualResourcePrediction?>();
            set => SetInstanceProperty(value);
        }
    }
}
