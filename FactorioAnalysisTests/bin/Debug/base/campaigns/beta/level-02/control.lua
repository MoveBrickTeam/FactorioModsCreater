require "util"
require "defines"
require "story"

function check_supplies(name, count)
  local has = game.player.get_item_count(name)
  if game.player.vehicle ~= nil then
    has = has + game.player.vehicle.get_item_count(name)
  end
  game.player.gui.left.objectives.table.add{type="label", caption=game.get_item_prototype(name).localised_name}
  if has < count then
    local label = game.player.gui.left.objectives.table.add{type="label", caption=has .. "/" .. count}
    label.style.font_color = {r = 1, g = 0.2, b = 0.2}
  else
    local label = game.player.gui.left.objectives.table.add{type="label", caption=count .. "/" .. count, style="caption_label_style"}
    label.style.font_color = {r = 0.3, g = 0.9, b = 0.3}
  end
  return  has >= count
end

script.on_init(function()
  global.story = story_init()
  game.player.force.disable_all_prototypes()
  game.map_settings.enemy_expansion.enabled = false
  game.evolution_factor = 0
  game.map_settings.enemy_evolution.enabled = false

  local recipe_list = game.player.force.recipes
  recipe_list["iron-plate"].enabled = true
  recipe_list["copper-plate"].enabled = true
  recipe_list["stone-brick"].enabled = true
  recipe_list["wood"].enabled = true
  recipe_list["stone-furnace"].enabled = true
  recipe_list["iron-stick"].enabled = true
  recipe_list["iron-axe"].enabled = true
  recipe_list["wooden-chest"].enabled = true
  recipe_list["iron-gear-wheel"].enabled = true
  recipe_list["burner-mining-drill"].enabled = true
  recipe_list["basic-transport-belt"].enabled = true
  recipe_list["burner-inserter"].enabled = true
  recipe_list["pipe"].enabled = true
  recipe_list["pipe-to-ground"].enabled = true
  recipe_list["boiler"].enabled = true
  recipe_list["steam-engine"].enabled = true
  recipe_list["electronic-circuit"].enabled = true
  recipe_list["copper-cable"].enabled = true
  recipe_list["pistol"].enabled = true
  recipe_list["basic-bullet-magazine"].enabled = true
  recipe_list["offshore-pump"].enabled = true
  recipe_list["small-electric-pole"].enabled = true
  recipe_list["basic-mining-drill"].enabled = true
  recipe_list["basic-inserter"].enabled = true
  recipe_list["radar"].enabled = true
  recipe_list["lab"].enabled = true
  recipe_list["science-pack-1"].enabled = true
  recipe_list["science-pack-2"].enabled = true
  recipe_list["stone-wall"].enabled = true
  recipe_list["repair-pack"].enabled = true
  
  local technologies = game.player.force.technologies
  technologies["automation"].researched = true
  technologies["logistics"].researched = true
  technologies["logistics-2"].enabled = true
  technologies["automobilism"].researched = true
  technologies["military"].researched = true
  technologies["military-2"].enabled = true
  technologies["optics"].researched = true
  technologies["steel-processing"].researched = true
  technologies["automation-2"].enabled = true
  technologies["turrets"].researched = true
  technologies["armor-making"].enabled = true
  technologies["armor-making-2"].enabled = true
  technologies["railway"].enabled = true
  technologies["automated-rail-transportation"].enabled = true
  technologies["electric-energy-distribution-1"].enabled = true
  technologies["bullet-damage-1"].researched = true
  technologies["bullet-damage-2"].enabled = true
  technologies["bullet-damage-3"].enabled = true
  technologies["bullet-speed-1"].researched = true
  technologies["bullet-speed-2"].enabled = true
  technologies["bullet-speed-3"].enabled = true
  technologies["advanced-material-processing"].enabled = true
  technologies["electronics"].enabled = true
  technologies["solar-energy"].enabled = true
  technologies["engine"].enabled = true
  technologies["rail-signals"].enabled = true
  technologies["advanced-electronics"].enabled = true
  technologies["inserter-stack-size-bonus-1"].enabled = true
  technologies["inserter-stack-size-bonus-2"].enabled = true
  
  local character = game.player.character
  character.insert{name = "iron-plate", count = 200}
  character.insert{name = "copper-plate", count = 100}
  character.insert{name = "coal", count = 20}
  character.insert{name = "basic-transport-belt", count = 50}
  character.insert{name = "basic-inserter", count = 10}
  character.insert{name = "small-electric-pole", count = 10}
  character.insert{name = "long-handed-inserter", count = 10}
  character.insert{name = "basic-mining-drill", count = 5}
  character.insert{name = "submachine-gun", count = 1}
  character.insert{name = "basic-bullet-magazine", count = 20}
  character.insert{name = "iron-axe", count = 1}
  character.insert{name = "electronic-circuit", count = 100}
  character.insert{name = "assembling-machine-1", count = 4}
  character.insert{name = "lab", count = 4}
  character.insert{name = "stone", count = 200}
  character.insert{name = "wood", count = 50}
  character.insert{name = "iron-gear-wheel", count = 50}
  character.insert{name = "pipe", count = 30}
end)

story_table =
{
  {
    {
      action =
      function()
        game.player.set_goal_description("")
        game.show_message_dialog{text = {"msg-came-too-late"}}
        game.show_message_dialog{text = {"msg-everyone-dead"}}
        game.show_message_dialog{text = {"msg-biters-are-dangerous"}}
        game.show_message_dialog{text = {"msg-recover-base"}}
        game.show_message_dialog{text = {"msg-rails"}}
      end
    },
    {
      condition = story_elapsed_check(3),
      action =
      function()
        game.player.set_goal_description({"goal-recover-base-and-research-railway"})
      end
    },
    {
      condition =
      function(event)
        return event.name == defines.events.on_research_finished and
               event.research.name == "automated-rail-transportation"
      end,
      action =
      function()
        game.player.set_goal_description("")
        game.player.print({"think-recover-railway"})
      end
    },
    {
      condition = story_elapsed_check(6),
      action =
      function()
        game.player.set_goal_description({"goal-get-supplies"})
        game.player.set_goal_description("")
      end
    },
    {
      init =
      function()
        local objectives = game.player.gui.left.add{type="frame", name="objectives", caption = {"goal-title"}, direction = "vertical"}
        objectives.add{type="label", caption = {"goal-get-supplies"}}
        objectives.add{type="label", caption = {"car-contents-counting-logic"}}
        objectives.add{type="table", colspan=2, name="table"}
      end,
      condition =
      function()
        local result = true
        game.player.gui.left.objectives.table.destroy()
        game.player.gui.left.objectives.add{type="table", colspan=2, name="table"}
        result = check_supplies("piercing-bullet-magazine", 2500) and result
        result = check_supplies("steel-plate", 1500) and result
        result = check_supplies("iron-plate", 3000) and result
        result = check_supplies("copper-plate", 3000) and result
        result = check_supplies("solar-panel", 50) and result
        return result
      end,
      action =
      function()
        game.player.set_goal_description("")
        game.show_message_dialog{text = {"msg-ready-to-go"}}
      end
    },
    {}
  }
}

story_init_helpers(story_table)

script.on_event(defines.events, function(event)
  story_update(global.story, event, "level-03")
end)

