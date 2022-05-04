# SAE 2.01

    <Grid Background="{StaticResource couleurArrierePlan}" Height="auto" Width="auto" Margin="25">
        <Grid>
            <Grid.RowDefinitions>
                <RowDefinition Height="0.7*"/>
                <RowDefinition Height="*"/>
                <RowDefinition Height="0.7*"/>
            </Grid.RowDefinitions>
            <TextBlock x:Name="nomPizza" Text="NOM PIZZA" Grid.Row="0" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="25" FontWeight="Bold" Margin="10" />
            <Image x:Name="imgPizza" Source="..\img\pizzas\epicees\spicy_hot_one.jpeg" Grid.Row="1" Margin="10,0,10,0"/>
            <Grid Grid.Row="2">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                </Grid.ColumnDefinitions>

                <Button Height="auto" Width="auto" Style="{x:Null}" BorderThickness="0" Background="{StaticResource couleurArrierePlan}" Margin="10,15,10,15">
                    <TextBlock Text="Plus d'informations" FontSize="20"/>
                </Button>



                <Grid Grid.Column="1">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition  Width="2*"/>
                        <ColumnDefinition/>
                        <ColumnDefinition/>
                        <ColumnDefinition/>
                    </Grid.ColumnDefinitions>
                    <Button Grid.Column="0" Height="50" BorderThickness="0" Background="{StaticResource couleurArrierePlan}" Style="{x:Null}" Width="60" Margin="30,0,0,0">
                        <Image Source="..\img\buttons\panier.png" Margin="5"/>
                    </Button>
                    <Button Grid.Column="1" FontSize="15" FontWeight="Medium" Height="25" BorderThickness="0" Background="{StaticResource couleurArrierePlan}" Style="{x:Null}">-</Button>
                    <TextBlock x:Name="quantite" Grid.Column="2" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="15" FontWeight="Medium">1</TextBlock>
                    <Button Grid.Column="3" FontSize="15" FontWeight="Medium" Height="25" BorderThickness="0" Background="{StaticResource couleurArrierePlan}" Style="{x:Null}">+</Button>
                </Grid>

            </Grid>
        </Grid>

    </Grid>